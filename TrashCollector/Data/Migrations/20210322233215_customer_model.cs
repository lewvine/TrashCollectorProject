using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class customer_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c009e17-9485-4aea-bc27-5a1a0b6d9d94");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d2661eb-e0f8-40dd-89d6-992a45b3e439");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80a64294-9f26-4cef-af8d-edcca765fc3f");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Zip = table.Column<int>(nullable: false),
                    AccountBalance = table.Column<int>(nullable: false),
                    RegularPickUpDay = table.Column<string>(nullable: true),
                    SpecialPickUpDay = table.Column<int>(nullable: false),
                    MyProperty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "80a64294-9f26-4cef-af8d-edcca765fc3f", "ae3222b4-ea1f-42fd-a9f5-58ab14ec4aa6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6d2661eb-e0f8-40dd-89d6-992a45b3e439", "a425f773-83e6-407b-9b44-8ffb6a7846f7", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5c009e17-9485-4aea-bc27-5a1a0b6d9d94", "a433ffc6-094e-4dc7-9f85-cd3ef992cc26", "Employee", "EMPLOYEE" });
        }
    }
}
