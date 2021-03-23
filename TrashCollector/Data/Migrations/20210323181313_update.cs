using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30b93b7b-c7cc-4b93-b637-2890bcad4f24");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "400266fa-1cae-4d5d-9c60-c66c07f9e103");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4eda731a-e987-44d5-b1ba-5a336f477b1e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3f411d4f-fe5c-499e-91d6-25f63726feef", "fd9ef01b-7459-4b18-818c-9a4cf5adf523", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec8efa9b-922a-4de5-8135-19321bf02151", "e3ea629b-285f-4276-a60f-3c2d13587fce", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9a699075-906c-4e08-ac06-60b9e312efd5", "7fcfd394-25a6-45d5-8cb6-538f41970790", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f411d4f-fe5c-499e-91d6-25f63726feef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a699075-906c-4e08-ac06-60b9e312efd5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec8efa9b-922a-4de5-8135-19321bf02151");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4eda731a-e987-44d5-b1ba-5a336f477b1e", "8a1b41bd-77de-4209-adb4-ea13ec159cc6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "400266fa-1cae-4d5d-9c60-c66c07f9e103", "15e03217-2eb2-4beb-9715-1b88124cb8c2", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "30b93b7b-c7cc-4b93-b637-2890bcad4f24", "cb0dd5ea-1aaa-46eb-8dbb-3d6a2da0af68", "Employee", "EMPLOYEE" });
        }
    }
}
