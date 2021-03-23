using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7564bd4c-bc15-4301-94e8-db068735c329");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed25cff6-1e59-4fbd-a6d2-28d35c682778");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdaa420a-60f7-434f-a1c4-8f9b70cbfdf5");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed25cff6-1e59-4fbd-a6d2-28d35c682778", "3834ec4b-17b5-4610-96c0-ba96b3ea3a55", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7564bd4c-bc15-4301-94e8-db068735c329", "a23a5e61-555f-4adf-9391-5b9550e28d72", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fdaa420a-60f7-434f-a1c4-8f9b70cbfdf5", "23d3600c-ef0e-48ae-9007-830dfdb07300", "Employee", "EMPLOYEE" });
        }
    }
}
