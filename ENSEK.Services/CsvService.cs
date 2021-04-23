using System;
using System.Collections.Generic;
using System.Text;

namespace ENSEK.Services
{
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using Common.Interfaces;
    using Common.Models;
    using CsvHelper;
    using CsvMappers;

    public class CsvService: ICSVService
    {
        public IEnumerable<MeterReadingModel> ReadCsvFileForMeterReadings(string location)
        {
            try
            {
                using var reader = new StreamReader(location, Encoding.Default);
                using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                csv.Context.RegisterClassMap<MeterReadingsMap>();
                var records = csv.GetRecords<MeterReadingModel>();
                return records.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
