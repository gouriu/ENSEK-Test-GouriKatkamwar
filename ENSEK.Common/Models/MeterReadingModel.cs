namespace ENSEK.Common.Models
{
    using System;

    public class MeterReadingModel
    {
        public Guid Id { get; set; }
        public int AccountId { get; set; }
        public DateTime MeterReadingDateTime { get; set; }
        public string MeterReadValue { get; set; }
    }
}