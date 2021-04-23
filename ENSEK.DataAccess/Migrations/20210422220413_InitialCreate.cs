using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ENSEK.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AccountId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeterReadings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AccountId = table.Column<int>(nullable: false),
                    MeterReadingDateTime = table.Column<DateTime>(nullable: false),
                    MeterReadValue = table.Column<int>(nullable: false),
                    AccountId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeterReadings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeterReadings_Accounts_AccountId1",
                        column: x => x.AccountId1,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountId", "FirstName", "LastName" },
                values: new object[] { new Guid("9f99d18f-635a-42c8-a09e-0a0bf1d2bb8e"), 2344, "Tommy", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountId", "FirstName", "LastName" },
                values: new object[] { new Guid("159f6356-183f-4549-9f64-3cf2ff3f2405"), 2233, "Barry", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountId", "FirstName", "LastName" },
                values: new object[] { new Guid("0c6cf628-54ae-4152-a66a-83741c14e0f4"), 8766, "Sally", "Test" });

            migrationBuilder.CreateIndex(
                name: "IX_MeterReadings_AccountId1",
                table: "MeterReadings",
                column: "AccountId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeterReadings");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
