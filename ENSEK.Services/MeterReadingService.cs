namespace ENSEK.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Common.Interfaces;
    using Common.Models;
    using CustomExceptions;
    using FluentValidation;

    public class MeterReadingService : IMeterReadingService
    {
        private readonly IMeterReadingsAccess _meterReadingsAccess;
        private readonly IAccountAccess _accountAccess;
        private readonly IValidator<MeterReadingModel> _meterReadingValidator;

        public MeterReadingService(IMeterReadingsAccess notificationsAccess, IAccountAccess accountAccess, IValidator<MeterReadingModel> meterReadingValidator)
        {
            _meterReadingsAccess = notificationsAccess;
            _accountAccess = accountAccess;
            _meterReadingValidator = meterReadingValidator;
        }


        public IReadOnlyCollection<MeterReadingModel> GetAllMeterReadings()
        {
            return _meterReadingsAccess.GetAllMeterReading().ToList();
        }

        public IReadOnlyCollection<MeterReadingModel> GetAllMeterReadingsByAccountId(int accountId)
        {
            var meterReadingsByAccountId = _meterReadingsAccess.GetAllMeterReadingsByAccountId(accountId);
            return meterReadingsByAccountId.ToList();
        }
        
        public async Task<ReadingUploadOutput> AddMeterReadingAsync(IEnumerable<MeterReadingModel> readings)
        {
            var failedCount = 0;
            var successCount = 0;
            foreach (var meterReadingModel in readings)
            {
                var validationResult = _meterReadingValidator.Validate(meterReadingModel);
                if(validationResult.IsValid)
                {
                    var account = await _accountAccess.GetAccountById(meterReadingModel.AccountId);
                    // if not associated with an account.
                    if (account == null)
                    {
                        failedCount++;
                        // log failed reading to the file or somewhere
                        continue;
                    }
                    
                    var entryExists = IfEntryExists(meterReadingModel);
                    if (entryExists)
                    {
                        failedCount++;
                        continue;
                    }

                    // Add notification to Database.
                    await _meterReadingsAccess.AddMeterReadingAsync(meterReadingModel);
                    successCount++;
                }
                else
                {
                    failedCount++;
                }
            }

            return new ReadingUploadOutput()
            {
                ReadingsUploaded = successCount,
                UploadFailed = failedCount
            };
        }

        private bool IfEntryExists(MeterReadingModel meterReadingModel)
        {
            var existingReadingsForThisAccount = _meterReadingsAccess.GetAllMeterReadingsByAccountId(meterReadingModel.AccountId);

            // if the record already exists then dont add.
            return existingReadingsForThisAccount.ToList().Exists(m =>
                m.AccountId == meterReadingModel.AccountId && m.MeterReadValue == m.MeterReadValue && m.MeterReadingDateTime == m.MeterReadingDateTime);
        }
    }
}
