using System;
using System.Collections.Generic;
using System.Text;

namespace ENSEK.Common.Interfaces
{
    using Models;

    public interface ICSVService
    {
        IEnumerable<MeterReadingModel> ReadCsvFileForMeterReadings(string location);
    }
}
