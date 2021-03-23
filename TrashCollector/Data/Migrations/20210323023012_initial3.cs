using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e10ad1b-4533-4f13-be67-a5e4120016d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5bcf309f-65bd-4283-b522-3d4146bd7b9e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f409a5a5-1f58-4d5a-8907-c8c6c8312289");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4367ed5a-6b7e-48d2-8d22-6d5b9d3f8764", "2d001c71-72ca-499a-8118-0d8ede38809d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a5868303-b2c0-4cff-b4d8-9c30265af018", "2c61b9ec-8cc6-49d8-8d7c-5d3c8dd3e5a5", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ffdbe105-e06a-484a-b5d5-a7d7e4f3a2c9", "beecd09c-231d-4a76-94d9-c937ffc279ee", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4367ed5a-6b7e-48d2-8d22-6d5b9d3f8764");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5868303-b2c0-4cff-b4d8-9c30265af018");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffdbe105-e06a-484a-b5d5-a7d7e4f3a2c9");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3e10ad1b-4533-4f13-be67-a5e4120016d4", "5a427ce5-4e37-4892-ae13-d50335ee27c8", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5bcf309f-65bd-4283-b522-3d4146bd7b9e", "85c0d15e-60be-4b31-a9bb-d80a3eae2004", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f409a5a5-1f58-4d5a-8907-c8c6c8312289", "cb677196-8173-44a5-9684-779f4a5776fa", "Employee", "EMPLOYEE" });
        }
    }
}
