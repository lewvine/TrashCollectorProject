using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "618d8291-6ead-4823-95a4-bf2d5aaeabd9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8651d7d4-aa0a-46e0-afe3-eabe39fc9ca2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e868b04d-6abb-4cc3-aaf7-210495b19db7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3b9d103e-0c54-45eb-a74e-5477ba271ea2", "28a7f090-5faf-4123-a83d-872cf68d7c74", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b9d103e-0c54-45eb-a74e-5477ba271ea2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8651d7d4-aa0a-46e0-afe3-eabe39fc9ca2", "a44f8bd3-f95f-487a-a015-4e6e0a40c723", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e868b04d-6abb-4cc3-aaf7-210495b19db7", "d8c8ca92-d3f3-4062-b897-fba948f1127c", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "618d8291-6ead-4823-95a4-bf2d5aaeabd9", "11ef0527-08e3-4412-8041-a59432638663", "Employee", "EMPLOYEE" });
        }
    }
}
