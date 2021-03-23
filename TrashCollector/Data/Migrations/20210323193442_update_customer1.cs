using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class update_customer1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1d9d2d9f-ba3b-44f0-b8b8-19b25498d79b", "a534c723-2f40-458c-8249-4ba5847acce2", "Admin", "ADMIN" },
                    { "6e2da958-28ba-4927-8177-2a64b114ee61", "c981af59-ee46-4e7e-80b5-dbe9bd01ec69", "Customer", "CUSTOMER" },
                    { "5ae00cbb-6788-40f7-98ac-dd19d6d9d1ea", "f3275a41-0bf9-452b-b578-73da31df2dea", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AccountBalance", "Email", "EndDate", "FirstName", "IdentityUserId", "LastName", "RecentlyPickedUp", "RegularPickUpDay", "SpecialPickUpDay", "StartDate", "Zip" },
                values: new object[,]
                {
                    { 3, 0, "Bob.Johnson@gmail.com", new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "Right Zip Code", null, "Customer", false, "Tuesday", new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), 91911 },
                    { 2, 0, "Bob.Johnson@gmail.com", new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), "Recently Picked Up True", null, "Customer", true, "Tuesday", new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), 91911 },
                    { 1, 0, "Bob.Johnson@gmail.com", new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Local), "End Date False", null, "Customer", false, "Tuesday", new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), 91911 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d9d2d9f-ba3b-44f0-b8b8-19b25498d79b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ae00cbb-6788-40f7-98ac-dd19d6d9d1ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e2da958-28ba-4927-8177-2a64b114ee61");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

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
    }
}
