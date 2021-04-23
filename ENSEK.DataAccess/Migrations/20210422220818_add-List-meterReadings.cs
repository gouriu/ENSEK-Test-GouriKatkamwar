using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ENSEK.DataAccess.Migrations
{
    public partial class addListmeterReadings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("0c6cf628-54ae-4152-a66a-83741c14e0f4"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("159f6356-183f-4549-9f64-3cf2ff3f2405"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("9f99d18f-635a-42c8-a09e-0a0bf1d2bb8e"));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountId", "FirstName", "LastName" },
                values: new object[] { new Guid("77e1aeec-3213-4775-a717-a93724cea3de"), 2344, "Tommy", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountId", "FirstName", "LastName" },
                values: new object[] { new Guid("106b01fb-cb2a-400c-b4d5-802aba7da10f"), 2233, "Barry", "Test" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountId", "FirstName", "LastName" },
                values: new object[] { new Guid("9629366e-964f-49d0-9b32-7deedbbae9f9"), 8766, "Sally", "Test" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("106b01fb-cb2a-400c-b4d5-802aba7da10f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("77e1aeec-3213-4775-a717-a93724cea3de"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("9629366e-964f-49d0-9b32-7deedbbae9f9"));

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
        }
    }
}
