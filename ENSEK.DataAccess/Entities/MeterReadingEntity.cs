namespace ENSEK.DataAccess.Entities
{
    using System;

    public class MeterReadingEntity
    {
        public Guid Id { get; set; }
        public int AccountId { get; set; }
        public DateTime MeterReadingDateTime { get; set; }
        public int MeterReadValue { get; set; }
        public AccountEntity Account { get; set; }
        
    }
}
