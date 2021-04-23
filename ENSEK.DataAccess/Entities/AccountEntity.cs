namespace ENSEK.DataAccess.Entities
{
    using System;
    using System.Collections.Generic;

    public class AccountEntity
    {
        public Guid Id { get; set; }
        public int AccountId { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public List<MeterReadingEntity> MeterReadings { get; set; }
    }
}