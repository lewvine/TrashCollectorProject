using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b9d103e-0c54-45eb-a74e-5477ba271ea2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3b9d103e-0c54-45eb-a74e-5477ba271ea2", "28a7f090-5faf-4123-a83d-872cf68d7c74", "Admin", "ADMIN" });
        }
    }
}
