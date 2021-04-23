using System;
using System.Collections.Generic;
using System.Text;

namespace ENSEK.Services.CsvMappers
{
    using CsvHelper.Configuration;
    using ENSEK.Common.Models;

    public sealed class MeterReadingsMap : ClassMap<MeterReadingModel>
    {
        public MeterReadingsMap()
        {
            Map(x => x.MeterReadValue).Name("MeterReadValue");
            Map(x => x.AccountId).Name("AccountId");
            Map(x => x.MeterReadingDateTime).Name("MeterReadingDateTime").TypeConverterOption.Format("dd/mm/yyyy");
        }
    }  
}
