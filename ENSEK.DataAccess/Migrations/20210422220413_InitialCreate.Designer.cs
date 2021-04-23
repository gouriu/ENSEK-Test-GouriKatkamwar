﻿// <auto-generated />
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
    [Migration("20210422220413_InitialCreate")]
    partial class InitialCreate
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
                            Id = new Guid("9f99d18f-635a-42c8-a09e-0a0bf1d2bb8e"),
                            AccountId = 2344,
                            FirstName = "Tommy",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = new Guid("159f6356-183f-4549-9f64-3cf2ff3f2405"),
                            AccountId = 2233,
                            FirstName = "Barry",
                            LastName = "Test"
                        },
                        new
                        {
                            Id = new Guid("0c6cf628-54ae-4152-a66a-83741c14e0f4"),
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
                        .WithMany()
                        .HasForeignKey("AccountId1");
                });
#pragma warning restore 612, 618
        }
    }
}