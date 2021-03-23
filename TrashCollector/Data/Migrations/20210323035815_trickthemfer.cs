using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class trickthemfer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "207a0932-f978-4c9b-9b59-39ed1997ba62");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "360cc3f5-5e71-4014-aea0-eb04e64bccec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffda1404-2224-41b9-8059-080024eb2248");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "207a0932-f978-4c9b-9b59-39ed1997ba62", "6b0d9b5e-5884-47b1-91af-a45bd10de89e", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "360cc3f5-5e71-4014-aea0-eb04e64bccec", "4b2d178e-5b1e-47ad-9b2d-837a3f04d64c", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ffda1404-2224-41b9-8059-080024eb2248", "a72e4b82-aee3-4a2c-9ea3-ca7a46bd5f65", "Employee", "EMPLOYEE" });
        }
    }
}
