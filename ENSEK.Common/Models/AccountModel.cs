namespace ENSEK.Common.odels
{
    using System;

    public class AccountModel
    {
        public Guid Id { get; set; }
        public int AccountId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}