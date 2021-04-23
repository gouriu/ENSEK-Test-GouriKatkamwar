namespace ENSEK.DataAccess.EntityConfigurations
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore.ValueGeneration;

    internal class MeterReadingEntityTypeConfiguration : IEntityTypeConfiguration<MeterReadingEntity>
    {
        public void Configure(EntityTypeBuilder<MeterReadingEntity> builder)
        {
            builder.Property(n => n.Id).HasValueGenerator<GuidValueGenerator>();
            builder.Property(n => n.AccountId).IsRequired();
        }
    }
}