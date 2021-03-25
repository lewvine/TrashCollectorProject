using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class added_location_specifics_to_customer_and_employee_models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b4a585d-a5f1-47a0-922b-c55433164bb4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "499e3241-5c82-4f75-b69c-609f5306d51a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a44021c-2827-401d-bf70-4c4976b9c58d");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Employees",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Employees",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Customers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Customers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e4432f94-a530-433d-a40e-815347aac0c1", "36c74860-ea5d-4e0a-a8f1-31d784e28c15", "Admin", "ADMIN" },
                    { "544eae53-de4b-4dd1-be5d-273fc6edc4b2", "33152c6e-cdfe-4388-bc74-e3eba1449d99", "Customer", "CUSTOMER" },
                    { "31db44cc-cd01-4ea7-b2c0-15f9042c8eb6", "2f940d1f-9c5c-4353-855f-d1adac8cc7cf", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "SpecialPickUpDay", "StartDate" },
                values: new object[] { new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "SpecialPickUpDay", "StartDate" },
                values: new object[] { new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "SpecialPickUpDay", "StartDate" },
                values: new object[] { new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "City",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2b4a585d-a5f1-47a0-922b-c55433164bb4", "734dab36-160c-4ab3-9bb3-2ae9a2c249f3", "Admin", "ADMIN" },
                    { "5a44021c-2827-401d-bf70-4c4976b9c58d", "2943be8f-a82b-440c-b95e-1a8cd00518a6", "Customer", "CUSTOMER" },
                    { "499e3241-5c82-4f75-b69c-609f5306d51a", "82baeddc-d069-4144-8131-50c3ccb5a871", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "SpecialPickUpDay", "StartDate" },
                values: new object[] { new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "SpecialPickUpDay", "StartDate" },
                values: new object[] { new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "SpecialPickUpDay", "StartDate" },
                values: new object[] { new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
