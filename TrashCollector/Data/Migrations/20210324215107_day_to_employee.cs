using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class day_to_employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "WorkDay",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ff0e07ab-c9bf-4600-b337-45b1c1b0ba9b", "581e6e46-1ee4-4400-b4a2-ae76157512f2", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "52d3a0c9-fcb5-4a7b-be9c-594cf9226d56", "a351f3f8-a240-4d73-adc1-10464cb065b9", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b74a6ec5-3551-497a-aa25-0c7f7784a1e6", "21c89088-5d78-4045-b8e1-ed64d85caf91", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52d3a0c9-fcb5-4a7b-be9c-594cf9226d56");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b74a6ec5-3551-497a-aa25-0c7f7784a1e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff0e07ab-c9bf-4600-b337-45b1c1b0ba9b");

            migrationBuilder.DropColumn(
                name: "WorkDay",
                table: "Employees");

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
    }
}
