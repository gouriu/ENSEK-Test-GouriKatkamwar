using System;
using Microsoft.EntityFrameworkCore;

namespace Notifications.DataAccess.Tests.Access
{
    using ENSEK.Common.Models;
    using ENSEK.DataAccess;
    using ENSEK.DataAccess.Entities;

    public class MeterReadingSeedDataFixture : IDisposable
    {
        public MeterReadingsDbContext Context { get; private set; }

        public MeterReadingSeedDataFixture()
        {
            var options = new DbContextOptionsBuilder<MeterReadingsDbContext>()
                .UseInMemoryDatabase(databaseName: "MemoryReadingDb")
                .Options;

            // Insert seed data into the database using one instance of the context
            Context = new MeterReadingsDbContext(options);

            Context.Accounts.AddRange( new AccountEntity
                {
                    Id = Guid.NewGuid(),
                    AccountId = 2345,
                    FirstName = "Jerry",
                    LastName = "Test"
                },
                new AccountEntity
                {
                    Id = Guid.NewGuid(),
                    AccountId = 2346,
                    FirstName = "Ollie",
                    LastName = "Test"
                });

            Context.SaveChanges();
            
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
