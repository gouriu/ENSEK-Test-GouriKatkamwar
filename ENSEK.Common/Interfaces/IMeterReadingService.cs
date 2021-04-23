namespace ENSEK.Common.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models;
    using Services;

    public interface IMeterReadingService
    {
        IReadOnlyCollection<MeterReadingModel> GetAllMeterReadings();

        IReadOnlyCollection<MeterReadingModel> GetAllMeterReadingsByAccountId(int accountId);

        Task<ReadingUploadOutput> AddMeterReadingAsync(IEnumerable<MeterReadingModel> readingModels);
    }
}
