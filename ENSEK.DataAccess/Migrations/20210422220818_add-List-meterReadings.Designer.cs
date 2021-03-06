// <auto-generated />
using System;
using ENSEK.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ENSEK.DataAccess.Migrations
{
    [DbContext(typeof(MeterReadingsDbContext))]
    [Migration("20210422220818_add-List-meterReadings")]
    partial class addListmeterReadings
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ENSEK.DataAccess.Entities.AccountEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("77e1aeec-3213-4775-a717-a93724cea3de"),
                            AccountId = 2344,
                            FirstName = "Tommy",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = new Guid("106b01fb-cb2a-400c-b4d5-802aba7da10f"),
                            AccountId = 2233,
                            FirstName = "Barry",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = new Guid("9629366e-964f-49d0-9b32-7deedbbae9f9"),
                            AccountId = 8766,
                            FirstName = "Sally",
                            LastName = "Test"
                        });
                });

            modelBuilder.Entity("ENSEK.DataAccess.Entities.MeterReadingEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<Guid?>("AccountId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("MeterReadValue")
                        .HasColumnType("int");

                    b.Property<DateTime>("MeterReadingDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AccountId1");

                    b.ToTable("MeterReadings");
                });

            modelBuilder.Entity("ENSEK.DataAccess.Entities.MeterReadingEntity", b =>
                {
                    b.HasOne("ENSEK.DataAccess.Entities.AccountEntity", "Account")
                        .WithMany("MeterReadings")
                        .HasForeignKey("AccountId1");
                });
#pragma warning restore 612, 618
        }
    }
}
