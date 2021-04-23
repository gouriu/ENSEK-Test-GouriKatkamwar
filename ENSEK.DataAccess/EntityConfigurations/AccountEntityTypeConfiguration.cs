namespace ENSEK.DataAccess.EntityConfigurations
{
    using System;
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore.ValueGeneration;

    internal class AccountEntityTypeConfiguration : IEntityTypeConfiguration<AccountEntity>
    {
        public void Configure(EntityTypeBuilder<AccountEntity> builder)
        {
            // configure value generation and conversion
            builder.Property(n => n.Id).HasValueGenerator<GuidValueGenerator>();
            builder.Property(n => n.AccountId).IsRequired();
            builder.Property(n => n.FirstName).IsRequired();
            builder.Property(n => n.LastName).IsRequired();

            // seed data
            builder.HasData(
                new AccountEntity()
                {
                    Id = Guid.NewGuid(),    
                    AccountId = 2344,
                    FirstName = "Tommy",
                    LastName = "Test"
                },
                new  AccountEntity
                {
                    Id = Guid.NewGuid(),
                    AccountId = 2233,
                    FirstName = "Barry", 
                    LastName = "Test"
                },
                new AccountEntity
                {
                    Id = Guid.NewGuid(),
                    AccountId = 8766,
                    FirstName = "Sally",
                    LastName = "Test"
                },
                new AccountEntity
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
                },
                new AccountEntity
                {
                    Id = Guid.NewGuid(),
                    AccountId = 2347,
                    FirstName = "Tara",
                    LastName = "Test"
                },
                new AccountEntity
                {
                    Id = Guid.NewGuid(),
                    AccountId = 2348,
                    FirstName = "Tammy",
                    LastName = "Test"
                },
                new AccountEntity
                {
                    Id = Guid.NewGuid(),
                    AccountId = 2349,
                    FirstName = "Simon",
                    LastName = "Test"
                },
                new AccountEntity
                {
                    Id = Guid.NewGuid(),
                    AccountId = 2350,
                    FirstName = "Colin",
                    LastName = "Test"
                },
                new AccountEntity
                {
                    Id = Guid.NewGuid(),
                    AccountId = 2351,
                    FirstName = "Gladys",
                    LastName = "Test"
                },
                new AccountEntity
                {
                    Id = Guid.NewGuid(),
                    AccountId = 2352,
                    FirstName = "Greg",
                    LastName = "Test"
                },
                new AccountEntity
                {
                    Id = Guid.NewGuid(),
                    AccountId = 2353,
                    FirstName = "Tony",
                    LastName = "Test"
                },
                new AccountEntity
                {
                    Id = Guid.NewGuid(),
                    AccountId = 2356,
                    FirstName = "Craig",
                    LastName = "Test"
                },
                new AccountEntity
                {
                    Id = Guid.NewGuid(),
                    AccountId = 6776,
                    FirstName = "Laura",
                    LastName = "Test"
                },
                new AccountEntity
                {
                    Id = Guid.NewGuid(),
                    AccountId = 4354,
                    FirstName = "Josh",
                    LastName = "Test"
                },
                new AccountEntity
                {
                    Id = Guid.NewGuid(),
                    AccountId = 1234,
                    FirstName = "Freya",
                    LastName = "Test"
                },
                new AccountEntity
                {
                    Id = Guid.NewGuid(),
                    AccountId = 1239,
                    FirstName = "Noddy",
                    LastName = "Test"
                },
                new AccountEntity
                {
                    Id = Guid.NewGuid(),
                    AccountId = 1240,
                    FirstName = "Archie",
                    LastName = "Test"
                },
                new AccountEntity
                {
                    Id = Guid.NewGuid(),
                    AccountId = 1241,
                    FirstName = "Lara",
                    LastName = "Test"
                },
                new AccountEntity
                {
                    Id = Guid.NewGuid(),
                    AccountId = 1242,
                    FirstName = "Tim",
                    LastName = "Test"
                },
                new AccountEntity
                {
                    Id = Guid.NewGuid(),
                    AccountId = 1243,
                    FirstName = "Graham",
                    LastName = "Test"
                },
                new AccountEntity
                {
                    Id = Guid.NewGuid(),
                    AccountId = 1244,
                    FirstName = "Tony",
                    LastName = "Test"
                },
                new AccountEntity
                {
                    Id = Guid.NewGuid(),
                    AccountId = 1245,
                    FirstName = "Neville",
                    LastName = "Test"
                },
                new AccountEntity
                {
                    Id = Guid.NewGuid(),
                    AccountId = 1246,
                    FirstName = "Jo",
                    LastName = "Test"
                },
                new AccountEntity
                {
                    Id = Guid.NewGuid(),
                    AccountId = 1247,
                    FirstName = "Jim",
                    LastName = "Test"
                },
                new AccountEntity
                {
                    Id = Guid.NewGuid(),
                    AccountId = 1248,
                    FirstName = "Pam",
                    LastName = "Test"
                }
                );

        }
    }
}