namespace ENSEK.DataAccess
{
    using Entities;
    using EntityConfigurations;
    using Microsoft.EntityFrameworkCore;

    public class MeterReadingsDbContext : DbContext
    {
        public MeterReadingsDbContext(DbContextOptions<MeterReadingsDbContext> options)
        : base(options)
        { }

        public DbSet<MeterReadingEntity> MeterReadings { get; set; }

        public DbSet<AccountEntity> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MeterReadingEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new AccountEntityTypeConfiguration());
        }
    }
}
