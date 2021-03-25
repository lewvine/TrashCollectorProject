using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class update_customer_add_location : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "MapLocation",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2b4a585d-a5f1-47a0-922b-c55433164bb4", "734dab36-160c-4ab3-9bb3-2ae9a2c249f3", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a44021c-2827-401d-bf70-4c4976b9c58d", "2943be8f-a82b-440c-b95e-1a8cd00518a6", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "499e3241-5c82-4f75-b69c-609f5306d51a", "82baeddc-d069-4144-8131-50c3ccb5a871", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "MapLocation",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1d9d2d9f-ba3b-44f0-b8b8-19b25498d79b", "a534c723-2f40-458c-8249-4ba5847acce2", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6e2da958-28ba-4927-8177-2a64b114ee61", "c981af59-ee46-4e7e-80b5-dbe9bd01ec69", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ae00cbb-6788-40f7-98ac-dd19d6d9d1ea", "f3275a41-0bf9-452b-b578-73da31df2dea", "Employee", "EMPLOYEE" });
        }
    }
}
