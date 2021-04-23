namespace ENSEK.Common.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models;

    public interface IMeterReadingsAccess
    {
        IEnumerable<MeterReadingModel> GetAllMeterReading();
        IEnumerable<MeterReadingModel> GetAllMeterReadingsByAccountId(int accountId);

        Task AddMeterReadingAsync(MeterReadingModel meterReading);
    }
}
