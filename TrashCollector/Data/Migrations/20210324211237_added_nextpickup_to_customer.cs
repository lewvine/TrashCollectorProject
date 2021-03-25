using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class added_nextpickup_to_customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31db44cc-cd01-4ea7-b2c0-15f9042c8eb6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "544eae53-de4b-4dd1-be5d-273fc6edc4b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4432f94-a530-433d-a40e-815347aac0c1");

            migrationBuilder.AddColumn<DateTime>(
                name: "NextPickUp",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e6566f6-d87a-4c52-a825-34bc67473945", "077a8d26-8d9d-4737-b351-7d6dffd1d8be", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cfd1ba28-81f1-4981-80c3-f880f6073e99", "0387ad23-eada-4b73-a535-3bf5e9f48263", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2a55fdf2-d39a-465e-bbbd-c036d2cb6b93", "b6508506-8eea-4f82-b18f-95d51bcf0258", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a55fdf2-d39a-465e-bbbd-c036d2cb6b93");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e6566f6-d87a-4c52-a825-34bc67473945");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfd1ba28-81f1-4981-80c3-f880f6073e99");

            migrationBuilder.DropColumn(
                name: "NextPickUp",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e4432f94-a530-433d-a40e-815347aac0c1", "36c74860-ea5d-4e0a-a8f1-31d784e28c15", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "544eae53-de4b-4dd1-be5d-273fc6edc4b2", "33152c6e-cdfe-4388-bc74-e3eba1449d99", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "31db44cc-cd01-4ea7-b2c0-15f9042c8eb6", "2f940d1f-9c5c-4353-855f-d1adac8cc7cf", "Employee", "EMPLOYEE" });
        }
    }
}
