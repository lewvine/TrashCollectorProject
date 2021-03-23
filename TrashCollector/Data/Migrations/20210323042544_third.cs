using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
