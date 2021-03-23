using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class update_customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "RecentlyPickedUp",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0ab71bdd-4e52-497a-b35d-53f35287c66b", "65d55a9d-23f9-413a-8a4f-676075df192d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d8544bc-57fd-427d-a521-023c420f4bad", "2e207b8a-9b45-4cc9-8bff-dceccd221059", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9e807a80-0302-457e-a0ca-081d82283940", "283e8526-115b-4f80-a111-6d19bd4f5502", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ab71bdd-4e52-497a-b35d-53f35287c66b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d8544bc-57fd-427d-a521-023c420f4bad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e807a80-0302-457e-a0ca-081d82283940");

            migrationBuilder.DropColumn(
                name: "RecentlyPickedUp",
                table: "Customers");

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
    }
}
