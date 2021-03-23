using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class edit_customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3009baed-409d-4724-a112-acfa04ef0724");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "369ff2ca-a701-4dbd-8dd6-180ade92f15a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77b95719-6b96-4ca5-b78d-972283957241");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "56521d33-7f9d-4024-9ab1-eeebdb19157a", "ec89c5a5-e1d9-4844-b6bb-668c118ec256", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59581a19-abe0-4383-81dd-dcba167874bf", "0d56bbf2-80d8-4669-9cd9-2e8642d330a0", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ca5903e6-042e-46b9-938d-802bdfcc7e0f", "d2662470-6a27-4ddd-b83f-fc29217da5b9", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56521d33-7f9d-4024-9ab1-eeebdb19157a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59581a19-abe0-4383-81dd-dcba167874bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca5903e6-042e-46b9-938d-802bdfcc7e0f");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "77b95719-6b96-4ca5-b78d-972283957241", "b4f09f99-8ae6-4bac-ab1e-44a1e48c8005", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "369ff2ca-a701-4dbd-8dd6-180ade92f15a", "45377adb-a601-4ec9-8f9c-60afe1d63205", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3009baed-409d-4724-a112-acfa04ef0724", "b760b3fb-9021-4178-b5c0-b5dcb598f1d9", "Employee", "EMPLOYEE" });
        }
    }
}
