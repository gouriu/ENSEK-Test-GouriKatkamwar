using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ENSEK.DataAccess.Migrations
{
    public partial class addmoreseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { new Guid("ec42fc64-7264-4e23-874e-855b9a73db28"), 2344, "Tommy", "Test" },
                    { new Guid("5645bd1a-0461-4792-8c9a-e4a051923b0c"), 1246, "Jo", "Test" },
                    { new Guid("6a300289-15a8-4193-8cbe-0f66063a7e4f"), 1245, "Neville", "Test" },
                    { new Guid("b576d2e1-3db6-4b9e-bb31-03763c3c4669"), 1244, "Tony", "Test" },
                    { new Guid("92322413-6038-45a9-b65b-a004b4a84ee9"), 1243, "Graham", "Test" },
                    { new Guid("f4e3539c-ae42-4faa-ac05-a25ed5cdb40b"), 1242, "Tim", "Test" },
                    { new Guid("5a22881f-f1fe-4955-bba1-29ce1999a3ae"), 1241, "Lara", "Test" },
                    { new Guid("bbe8a8e8-8c52-4435-8012-6e70135bea34"), 1240, "Archie", "Test" },
                    { new Guid("fa379fee-d384-48d0-95c1-ee764f87da28"), 1239, "Noddy", "Test" },
                    { new Guid("23cdabb5-2a70-4914-a521-0fdc8699381f"), 1234, "Freya", "Test" },
                    { new Guid("ff8ddb59-24ef-4df5-b111-186981a20d77"), 4354, "Josh", "Test" },
                    { new Guid("cf5f2112-a840-4160-9e91-079529e65d64"), 6776, "Laura", "Test" },
                    { new Guid("141ad736-f525-4bbc-8ef9-8898602b65bd"), 2356, "Craig", "Test" },
                    { new Guid("5ec79839-cd8b-431c-be0f-ea9fbee4eb51"), 2353, "Tony", "Test" },
                    { new Guid("e3f5d8db-1c2c-4007-9a55-d8dca71c3ca6"), 2352, "Greg", "Test" },
                    { new Guid("685cf5f7-1d28-473f-a6c4-0299ec965217"), 2351, "Gladys", "Test" },
                    { new Guid("72ccde40-9309-4659-88c8-7db6de34b78c"), 2350, "Colin", "Test" },
                    { new Guid("6f0f6ca4-f4a8-464a-b2b8-340944f1415e"), 2349, "Simon", "Test" },
                    { new Guid("fcca5f02-bd37-4278-843f-18863a4f529f"), 2348, "Tammy", "Test" },
                    { new Guid("cc5c8640-8d44-41e2-b319-e124927a136c"), 2347, "Tara", "Test" },
                    { new Guid("2cfdb621-9441-4a74-ad7e-4db6c4ad0d55"), 2346, "Ollie", "Test" },
                    { new Guid("b1825046-dbaa-4b45-93e7-e32ef55f4ccf"), 2345, "Jerry", "Test" },
                    { new Guid("105ce48b-ee7a-439b-817c-4a927698f1cd"), 8766, "Sally", "Test" },
                    { new Guid("81f17936-4ed0-41cf-8f8e-38ae3702b1f6"), 2233, "Barry", "Test" },
                    { new Guid("2ca32105-4704-408f-a301-984c02d706f6"), 1247, "Jim", "Test" },
                    { new Guid("32a55030-b1ad-4806-af95-b452642cfb92"), 1248, "Pam", "Test" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("105ce48b-ee7a-439b-817c-4a927698f1cd"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("141ad736-f525-4bbc-8ef9-8898602b65bd"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("23cdabb5-2a70-4914-a521-0fdc8699381f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2ca32105-4704-408f-a301-984c02d706f6"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("2cfdb621-9441-4a74-ad7e-4db6c4ad0d55"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("32a55030-b1ad-4806-af95-b452642cfb92"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5645bd1a-0461-4792-8c9a-e4a051923b0c"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5a22881f-f1fe-4955-bba1-29ce1999a3ae"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("5ec79839-cd8b-431c-be0f-ea9fbee4eb51"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("685cf5f7-1d28-473f-a6c4-0299ec965217"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("6a300289-15a8-4193-8cbe-0f66063a7e4f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("6f0f6ca4-f4a8-464a-b2b8-340944f1415e"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("72ccde40-9309-4659-88c8-7db6de34b78c"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("81f17936-4ed0-41cf-8f8e-38ae3702b1f6"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("92322413-6038-45a9-b65b-a004b4a84ee9"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b1825046-dbaa-4b45-93e7-e32ef55f4ccf"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("b576d2e1-3db6-4b9e-bb31-03763c3c4669"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("bbe8a8e8-8c52-4435-8012-6e70135bea34"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("cc5c8640-8d44-41e2-b319-e124927a136c"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("cf5f2112-a840-4160-9e91-079529e65d64"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("e3f5d8db-1c2c-4007-9a55-d8dca71c3ca6"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("ec42fc64-7264-4e23-874e-855b9a73db28"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("f4e3539c-ae42-4faa-ac05-a25ed5cdb40b"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("fa379fee-d384-48d0-95c1-ee764f87da28"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("fcca5f02-bd37-4278-843f-18863a4f529f"));

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("ff8ddb59-24ef-4df5-b111-186981a20d77"));

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
    }
}
