using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "AspNetRoles",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(nullable: false),
            //        Name = table.Column<string>(maxLength: 256, nullable: true),
            //        NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
            //        ConcurrencyStamp = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetRoles", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUsers",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(nullable: false),
            //        UserName = table.Column<string>(maxLength: 256, nullable: true),
            //        NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
            //        Email = table.Column<string>(maxLength: 256, nullable: true),
            //        NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
            //        EmailConfirmed = table.Column<bool>(nullable: false),
            //        PasswordHash = table.Column<string>(nullable: true),
            //        SecurityStamp = table.Column<string>(nullable: true),
            //        ConcurrencyStamp = table.Column<string>(nullable: true),
            //        PhoneNumber = table.Column<string>(nullable: true),
            //        PhoneNumberConfirmed = table.Column<bool>(nullable: false),
            //        TwoFactorEnabled = table.Column<bool>(nullable: false),
            //        LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
            //        LockoutEnabled = table.Column<bool>(nullable: false),
            //        AccessFailedCount = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUsers", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetRoleClaims",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        RoleId = table.Column<string>(nullable: false),
            //        ClaimType = table.Column<string>(nullable: true),
            //        ClaimValue = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "AspNetRoles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserClaims",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserId = table.Column<string>(nullable: false),
            //        ClaimType = table.Column<string>(nullable: true),
            //        ClaimValue = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_AspNetUserClaims_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserLogins",
            //    columns: table => new
            //    {
            //        LoginProvider = table.Column<string>(nullable: false),
            //        ProviderKey = table.Column<string>(nullable: false),
            //        ProviderDisplayName = table.Column<string>(nullable: true),
            //        UserId = table.Column<string>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserLogins_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserRoles",
            //    columns: table => new
            //    {
            //        UserId = table.Column<string>(nullable: false),
            //        RoleId = table.Column<string>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "AspNetRoles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_AspNetUserRoles_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserTokens",
            //    columns: table => new
            //    {
            //        UserId = table.Column<string>(nullable: false),
            //        LoginProvider = table.Column<string>(nullable: false),
            //        Name = table.Column<string>(nullable: false),
            //        Value = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserTokens_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

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
                    SpecialPickUpDay = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Zip = table.Column<int>(nullable: false),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

    //        migrationBuilder.InsertData(
    //            table: "AspNetRoles",
    //            columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
    //            values: new object[] { "ed25cff6-1e59-4fbd-a6d2-28d35c682778", "3834ec4b-17b5-4610-96c0-ba96b3ea3a55", "Admin", "ADMIN" });

    //        migrationBuilder.InsertData(
    //            table: "AspNetRoles",
    //            columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
    //            values: new object[] { "7564bd4c-bc15-4301-94e8-db068735c329", "a23a5e61-555f-4adf-9391-5b9550e28d72", "Customer", "CUSTOMER" });

    //        migrationBuilder.InsertData(
    //            table: "AspNetRoles",
    //            columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
    //            values: new object[] { "fdaa420a-60f7-434f-a1c4-8f9b70cbfdf5", "23d3600c-ef0e-48ae-9007-830dfdb07300", "Employee", "EMPLOYEE" });

    //        migrationBuilder.CreateIndex(
    //            name: "IX_AspNetRoleClaims_RoleId",
    //            table: "AspNetRoleClaims",
    //            column: "RoleId");

    //        migrationBuilder.CreateIndex(
    //            name: "RoleNameIndex",
    //            table: "AspNetRoles",
    //            column: "NormalizedName",
    //            unique: true,
    //            filter: "[NormalizedName] IS NOT NULL");

    //        migrationBuilder.CreateIndex(
    //            name: "IX_AspNetUserClaims_UserId",
    //            table: "AspNetUserClaims",
    //            column: "UserId");

    //        migrationBuilder.CreateIndex(
    //            name: "IX_AspNetUserLogins_UserId",
    //            table: "AspNetUserLogins",
    //            column: "UserId");

    //        migrationBuilder.CreateIndex(
    //            name: "IX_AspNetUserRoles_RoleId",
    //            table: "AspNetUserRoles",
    //            column: "RoleId");

    //        migrationBuilder.CreateIndex(
    //            name: "EmailIndex",
    //            table: "AspNetUsers",
    //            column: "NormalizedEmail");

    //        migrationBuilder.CreateIndex(
    //            name: "UserNameIndex",
    //            table: "AspNetUsers",
    //            column: "NormalizedUserName",
    //            unique: true,
    //            filter: "[NormalizedUserName] IS NOT NULL");

    //        migrationBuilder.CreateIndex(
    //            name: "IX_Customers_IdentityUserId",
    //            table: "Customers",
    //            column: "IdentityUserId");

    //        migrationBuilder.CreateIndex(
    //            name: "IX_Employees_IdentityUserId",
    //            table: "Employees",
    //            column: "IdentityUserId");
    //    }

    //    protected override void Down(MigrationBuilder migrationBuilder)
    //    {
    //        migrationBuilder.DropTable(
    //            name: "AspNetRoleClaims");

    //        migrationBuilder.DropTable(
    //            name: "AspNetUserClaims");

    //        migrationBuilder.DropTable(
    //            name: "AspNetUserLogins");

    //        migrationBuilder.DropTable(
    //            name: "AspNetUserRoles");

    //        migrationBuilder.DropTable(
    //            name: "AspNetUserTokens");

    //        migrationBuilder.DropTable(
    //            name: "Customers");

    //        migrationBuilder.DropTable(
    //            name: "Employees");

    //        migrationBuilder.DropTable(
    //            name: "AspNetRoles");

    //        migrationBuilder.DropTable(
    //            name: "AspNetUsers");
        }
    }
}
