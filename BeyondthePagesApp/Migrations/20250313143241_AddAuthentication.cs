using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeyondthePagesApp.Migrations
{
    /// <inheritdoc />
    public partial class AddAuthentication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Employees",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 52, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 18, 28, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 21, 35, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 19, 21, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 0, 31, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 4, 3, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 12, 5, 19, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 13, 35, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 8, 58, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 20, 16, 2, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 9, 14, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 3, 6, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 8, 52, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 14, 11, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 14, 41, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 18, 16, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 1, 12, 40, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 31, 15, 16, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 7, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 4, 41, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 19, 4, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 8, 44, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 13, 56, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 8, 7, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 4, 0, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 11, 31, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 12, 54, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 12, 48, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 0, 46, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 6, 35, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 10, 29, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 14, 52, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 18, 51, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 20, 47, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 3, 5, 30, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 11, 7, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 19, 56, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 21, 2, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 14, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 21, 21, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 27, 17, 35, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 0, 6, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 22,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 13, 48, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 3, 32, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 23,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 2, 18, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 17, 0, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 24,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 19, 16, 14, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 5, 4, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 25,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 13, 38, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 7, 56, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 26,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 10, 22, 4, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 12, 53, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 27,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 24, 5, 15, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 21, 56, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 28,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 13, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 3, 16, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 29,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 9, 47, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 8, 12, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 30,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 26, 8, 53, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 9, 25, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 31,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 6, 37, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 11, 22, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 32,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 23, 13, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 6, 43, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 33,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 11, 13, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 1, 13, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 34,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 22, 25, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 2, 20, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 35,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 4, 2, 37, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 22, 43, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 36,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 5, 30, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 11, 0, 34, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 37,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 0, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 10, 9, 32, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 38,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 8, 29, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 7, 45, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 39,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 16, 5, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 16, 8, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 40,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 23, 14, 27, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 18, 26, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 41,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 12, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 18, 26, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 42,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 9, 13, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 19, 20, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 43,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 0, 26, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 7, 23, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 44,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 8, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 13, 23, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 45,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 23, 38, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 0, 14, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 46,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 12, 11, 8, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 22, 44, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 47,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 15, 38, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 7, 45, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 48,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 13, 20, 39, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 4, 43, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 49,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 1, 3, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 12, 9, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 50,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 3, 19, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 5, 15, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 51,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 15, 17, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 12, 27, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 52,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 9, 21, 10, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 23, 50, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 53,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 13, 9, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 17, 3, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 54,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 8, 0, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 8, 3, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 55,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 14, 16, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 4, 44, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 56,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 16, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 12, 54, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 57,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 21, 47, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 12, 19, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 58,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 2, 3, 16, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 11, 24, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 59,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 23, 44, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 6, 30, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 60,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 13, 53, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 16, 44, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 61,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 11, 10, 50, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 23, 53, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 62,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 22, 39, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 14, 28, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 63,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 15, 0, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 15, 15, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 64,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 14, 51, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 16, 37, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 65,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 9, 47, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 10, 7, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 66,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 0, 6, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 6, 17, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 67,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 9, 59, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 7, 21, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 68,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 53, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 15, 16, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 69,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 0, 20, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 8, 41, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 70,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 25, 11, 59, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 12, 56, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 71,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 30, 13, 34, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 23, 24, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 72,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 50, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 2, 1, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 73,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 5, 9, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 9, 11, 59, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 74,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 22, 44, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 14, 49, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 75,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 7, 18, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 10, 43, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 76,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 14, 56, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 11, 25, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 77,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 22, 19, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 21, 36, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 78,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 9, 24, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 4, 33, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 79,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 22, 15, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 21, 19, 0, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 80,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 5, 52, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 10, 54, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 81,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 7, 59, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 21, 7, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 82,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 4, 55, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 23, 8, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 83,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 9, 49, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 1, 50, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 84,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 12, 47, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 4, 54, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 85,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 2, 27, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 13, 51, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 86,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 9, 37, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 9, 21, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 87,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 11, 8, 46, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 0, 1, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 88,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 17, 19, 57, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 8, 35, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 89,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 4, 32, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 5, 21, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 90,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 13, 27, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 7, 1, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 91,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 5, 2, 35, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 17, 18, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 92,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 1, 0, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 23, 19, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 93,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 18, 3, 10, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 2, 10, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 94,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 5, 40, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 8, 47, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 95,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 4, 11, 52, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 20, 35, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 96,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 1, 55, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 18, 17, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 97,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 21, 11, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 6, 51, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 98,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 9, 59, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 1, 43, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 99,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 21, 39, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 20, 43, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 100,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 5, 16, 45, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 22, 25, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 101,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 18, 18, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 19, 51, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 102,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 20, 26, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 8, 32, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 103,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 3, 23, 11, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 8, 9, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 104,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 10, 0, 59, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 14, 6, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 105,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 2, 46, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 0, 16, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 106,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 16, 16, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 23, 59, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 107,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 2, 33, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 10, 27, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 108,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 18, 30, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 9, 18, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 109,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 15, 45, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 17, 56, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 110,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 10, 2, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 12, 1, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 111,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 13, 23, 43, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 12, 23, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 112,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 27, 16, 16, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 10, 11, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 113,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 0, 22, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 18, 45, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 114,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 19, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 9, 21, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 115,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 11, 14, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 8, 32, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 116,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 12, 54, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 4, 28, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 117,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 11, 38, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 14, 6, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 118,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 56, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 1, 24, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 119,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 18, 13, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 19, 42, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 120,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 4, 48, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 4, 38, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 121,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 5, 43, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 1, 5, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 122,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 11, 13, 45, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 0, 21, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 123,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 4, 1, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 14, 23, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 124,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 13, 5, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 1, 31, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 125,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 5, 28, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 11, 6, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 126,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 19, 36, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 15, 35, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 127,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 23, 42, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 21, 27, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 128,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 11, 13, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 2, 58, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 129,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 17, 10, 49, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 15, 56, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 130,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 30, 21, 2, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 17, 57, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 131,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 2, 53, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 0, 6, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 132,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 6, 44, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 7, 50, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 133,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 53, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 17, 42, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 134,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 20, 40, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 5, 48, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 135,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 2, 51, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 23, 55, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 136,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 8, 38, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 9, 9, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 137,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 4, 7, 34, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 5, 59, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 138,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 19, 2, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 17, 47, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 139,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 1, 53, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 15, 9, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 140,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 21, 43, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 21, 22, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 141,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 15, 26, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 17, 59, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 142,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 18, 3, 33, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 14, 38, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 143,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 8, 13, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 5, 34, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 144,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 2, 18, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 23, 10, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 145,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 8, 53, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 16, 53, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 146,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 9, 29, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 0, 24, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 147,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 45, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 9, 44, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 148,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 13, 48, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 3, 6, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 149,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 19, 59, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 3, 14, 46, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 150,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 3, 24, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 17, 4, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 151,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 13, 19, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 12, 36, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 152,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 9, 3, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 22, 28, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 153,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 11, 19, 22, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 9, 3, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 154,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 30, 2, 0, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 21, 30, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 155,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 20, 3, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 9, 22, 45, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 156,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 3, 3, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 7, 19, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 157,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 18, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 13, 16, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 158,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 15, 21, 34, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 9, 15, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 159,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 46, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 10, 34, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 160,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 16, 3, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 3, 15, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 161,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 7, 2, 1, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 12, 26, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 162,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 19, 36, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 16, 3, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 163,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 12, 33, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 20, 19, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 164,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 10, 44, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 7, 18, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 165,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 7, 40, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 18, 34, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 166,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 1, 21, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 2, 9, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 167,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 14, 20, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 3, 39, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 168,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 13, 3, 9, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 23, 19, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 169,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 11, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 9, 48, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 170,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 11, 4, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 18, 7, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 171,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 12, 20, 41, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 19, 42, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 172,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 33, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 20, 13, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 173,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 28, 7, 42, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 10, 12, 33, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 174,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 6, 42, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 10, 32, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 175,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 17, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 14, 49, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 176,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 44, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 17, 7, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 177,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 24, 3, 27, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 23, 7, 54, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 178,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 54, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 21, 45, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 179,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 21, 35, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 2, 44, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 180,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 15, 42, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 11, 5, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 181,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 7, 19, 7, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 8, 42, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 182,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 23, 37, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 5, 25, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 183,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 17, 19, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 9, 1, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 184,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 14, 35, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 7, 7, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 185,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 11, 55, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 6, 24, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 186,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 10, 58, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 23, 30, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 187,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 23, 59, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 21, 42, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 188,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 20, 38, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 11, 38, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 189,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 52, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 16, 20, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 190,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 43, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 21, 42, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 191,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 9, 3, 10, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 9, 11, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 192,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 18, 57, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 19, 7, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 193,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 1, 4, 58, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 1, 59, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 194,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 13, 40, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 17, 25, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 195,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 13, 31, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 11, 41, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 196,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 10, 9, 38, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 0, 49, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 197,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 14, 39, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 6, 33, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 198,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 9, 37, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 23, 19, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 199,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 14, 11, 32, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 12, 21, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 200,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 1, 11, 35, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 14, 4, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 201,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 20, 9, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 11, 16, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 202,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 17, 12, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 5, 58, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 203,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 23, 6, 6, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 13, 24, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 204,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 11, 17, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 4, 7, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 205,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 20, 19, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 3, 35, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 206,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 5, 19, 26, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 2, 1, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 207,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 9, 28, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 20, 53, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 208,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 20, 53, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 2, 59, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 209,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 3, 43, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 23, 58, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 210,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 23, 20, 36, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 19, 46, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 211,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 1, 45, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 19, 8, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 212,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 27, 21, 59, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 29, 9, 28, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 213,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 25, 15, 38, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 12, 6, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 214,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 1, 57, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 17, 25, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 215,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 23, 59, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 18, 45, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 216,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 0, 58, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 4, 8, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 217,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 3, 10, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 17, 1, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 218,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 20, 52, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 19, 18, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 219,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 9, 6, 49, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 9, 39, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 220,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 1, 5, 46, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 13, 32, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 221,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 4, 13, 58, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 13, 19, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 222,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 14, 42, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 0, 27, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 223,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 16, 3, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 18, 45, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 224,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 10, 6, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 14, 58, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 225,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 14, 31, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 14, 55, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 226,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 21, 35, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 22, 1, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 227,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 12, 3, 15, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 26, 4, 31, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 228,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 18, 30, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 14, 41, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 229,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 31, 21, 22, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 13, 25, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 230,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 2, 7, 53, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 28, 3, 50, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 231,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 20, 57, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 23, 20, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 232,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 28, 3, 14, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 3, 34, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 233,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 14, 26, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 2, 31, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 234,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 6, 10, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 2, 3, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 235,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 5, 16, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 17, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 236,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 8, 23, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 8, 44, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 237,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 19, 48, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 18, 27, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 238,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 9, 1, 37, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 1, 19, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 239,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 31, 15, 37, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 22, 18, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 240,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 18, 42, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 14, 11, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 241,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 28, 9, 23, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 16, 54, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 242,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 5, 34, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 21, 4, 58, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 243,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 28, 5, 26, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 14, 28, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 244,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 6, 11, 48, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 5, 10, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 245,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 5, 11, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 19, 19, 7, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 246,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 9, 19, 12, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 8, 39, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 247,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 14, 40, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 19, 38, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 248,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 16, 39, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 21, 14, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 249,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 29, 6, 42, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 10, 40, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 250,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 8, 19, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 3, 19, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 251,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 16, 4, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 19, 33, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 252,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 23, 50, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 0, 54, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 253,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 15, 59, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 7, 39, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 254,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 17, 20, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 6, 11, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 255,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 23, 54, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 3, 20, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 256,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 58, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 16, 5, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 257,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 29, 3, 1, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 11, 28, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 258,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 9, 21, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 18, 26, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 259,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 2, 19, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 20, 56, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 260,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 52, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 7, 1, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 261,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 14, 6, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 11, 2, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 262,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 4, 21, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 0, 44, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 263,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 23, 58, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 19, 52, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 264,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 6, 36, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 6, 56, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 265,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 4, 24, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 22, 15, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 266,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 12, 14, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 11, 59, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 267,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 12, 48, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 3, 5, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 268,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 20, 11, 5, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 23, 21, 20, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 269,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 18, 24, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 14, 8, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 270,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 9, 17, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 19, 3, 57, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 271,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 24, 21, 34, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 4, 7, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 272,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 14, 2, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 16, 36, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 273,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 23, 56, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 9, 17, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 274,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 11, 33, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 16, 47, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 275,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 18, 19, 29, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 8, 38, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 276,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 5, 57, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 14, 11, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 277,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 33, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 2, 39, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 278,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 6, 3, 14, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 2, 29, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 279,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 11, 21, 1, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 9, 39, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 280,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 0, 24, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 23, 45, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 281,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 20, 17, 14, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 22, 27, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 282,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 21, 13, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 19, 1, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 283,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 9, 48, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 14, 11, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 284,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 0, 10, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 7, 11, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 285,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 21, 19, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 6, 30, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 286,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 14, 24, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 18, 37, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 287,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 16, 17, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 4, 43, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 288,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 11, 54, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 16, 17, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 289,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 19, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 8, 40, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 290,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 2, 47, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 4, 28, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 291,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 13, 14, 50, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 0, 21, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 292,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 19, 31, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 29, 22, 27, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 293,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 12, 22, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 18, 33, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 294,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 4, 7, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 22, 44, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 295,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 4, 3, 49, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 2, 25, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 296,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 0, 37, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 1, 1, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 297,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 18, 26, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 12, 26, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 298,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 17, 8, 10, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 9, 3, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 299,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 0, 0, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 6, 43, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 300,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 29, 7, 57, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 12, 51, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 301,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 4, 41, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 12, 12, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 302,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 12, 29, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 2, 43, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 303,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 22, 56, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 18, 21, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 304,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 4, 10, 39, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 21, 30, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 305,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 9, 10, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 21, 6, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 306,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 20, 36, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 12, 9, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 307,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 1, 22, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 3, 30, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 308,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 6, 13, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 19, 55, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 309,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 3, 32, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 22, 55, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 310,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 7, 42, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 3, 36, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 311,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 12, 0, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 22, 4, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 312,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 28, 10, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 8, 32, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 313,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 5, 3, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 10, 26, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 314,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 8, 50, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 3, 3, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 315,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 2, 59, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 43, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 316,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 8, 43, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 16, 39, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 317,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 2, 57, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 0, 44, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 318,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 23, 27, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 9, 46, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 319,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 4, 43, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 11, 54, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 320,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 1, 21, 37, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 19, 25, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 321,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 9, 18, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 9, 16, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 322,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 22, 13, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 4, 1, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 323,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 5, 12, 1, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 13, 55, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 324,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 14, 34, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 11, 30, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 325,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 8, 44, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 5, 41, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 326,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 13, 52, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 5, 39, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 327,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 15, 4, 23, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 12, 43, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 328,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 15, 50, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 21, 56, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 329,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 9, 57, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 19, 57, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 330,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 5, 29, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 21, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 331,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 20, 7, 44, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 11, 12, 5, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 332,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 6, 21, 0, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 13, 29, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 333,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 56, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 0, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 334,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 2, 16, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 0, 22, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 335,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 9, 52, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 11, 47, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 336,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 9, 4, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 11, 59, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 337,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 1, 5, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 6, 1, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 338,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 20, 11, 2, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 2, 7, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 339,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 18, 42, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 7, 2, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 340,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 19, 22, 57, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 1, 37, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 341,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 8, 32, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 23, 5, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 342,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 8, 12, 39, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 2, 32, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 343,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 24, 17, 49, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 14, 47, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 344,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 26, 8, 35, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 7, 6, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 345,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 18, 41, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 20, 34, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 346,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 14, 38, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 22, 27, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 347,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 5, 21, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 21, 11, 40, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 348,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 20, 17, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 8, 51, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 349,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 26, 10, 4, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 6, 59, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 350,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 21, 6, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 12, 54, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 351,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 11, 53, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 10, 41, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 352,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 7, 26, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 21, 48, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 353,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 7, 24, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 15, 7, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 354,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 12, 46, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 13, 53, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 355,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 12, 16, 58, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 15, 32, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 356,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 11, 1, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 14, 19, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 357,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 14, 25, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 7, 40, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 358,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 13, 15, 26, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 2, 19, 34, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 359,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 18, 52, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 1, 5, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 360,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 18, 43, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 2, 1, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 361,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 11, 21, 54, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 10, 59, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 362,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 3, 0, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 21, 16, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 363,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 5, 21, 58, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 18, 26, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 364,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 14, 15, 15, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 13, 43, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 365,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 21, 58, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 20, 23, 12, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 366,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 20, 38, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 5, 27, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 367,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 15, 0, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 8, 56, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 368,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 1, 57, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 12, 10, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 369,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 5, 59, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 17, 51, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 370,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 21, 9, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 23, 29, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 371,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 21, 27, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 20, 48, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 372,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 9, 26, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 16, 28, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 373,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 8, 25, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 14, 56, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 374,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 19, 18, 35, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 21, 39, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 375,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 8, 5, 52, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 17, 17, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 376,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 13, 21, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 7, 56, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 377,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 2, 3, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 18, 9, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 378,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 42, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 10, 35, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 379,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 7, 51, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 5, 36, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 380,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 11, 20, 55, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 13, 41, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 381,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 2, 9, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 14, 20, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 382,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 16, 5, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 14, 18, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 383,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 7, 14, 35, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 12, 4, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 384,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 18, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 4, 36, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 385,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 1, 4, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 16, 10, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 386,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 6, 44, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 3, 45, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 387,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 5, 54, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 10, 1, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 388,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 24, 1, 35, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 13, 29, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 389,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 20, 50, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 5, 57, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 390,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 23, 18, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 1, 1, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 391,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 2, 2, 31, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 10, 0, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 392,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 11, 10, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 3, 17, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 393,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 9, 11, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 20, 58, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 394,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 7, 55, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 5, 19, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 395,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 29, 11, 43, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 3, 2, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 396,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 2, 44, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 1, 15, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 397,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 7, 16, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 13, 34, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 398,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 6, 11, 17, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 16, 23, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 399,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 25, 20, 48, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 18, 20, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 400,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 30, 4, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 26, 1, 50, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 401,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 53, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 14, 55, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 402,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 15, 8, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 18, 18, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 403,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 23, 49, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 14, 43, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 404,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 16, 33, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 6, 6, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 405,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 5, 8, 25, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 20, 22, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 406,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 21, 57, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 5, 46, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 407,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 4, 21, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 8, 7, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 408,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 24, 15, 18, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 7, 8, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 409,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 6, 36, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 14, 33, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 410,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 44, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 23, 35, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 411,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 17, 16, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 11, 45, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 412,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 24, 7, 25, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 3, 19, 24, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 413,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 2, 27, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 18, 17, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 414,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 16, 37, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 19, 3, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 415,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 15, 19, 3, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 9, 31, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 416,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 2, 46, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 4, 30, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 417,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 0, 14, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 13, 0, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 418,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 22, 58, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 10, 57, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 419,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 21, 39, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 10, 14, 49, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 420,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 16, 17, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 16, 18, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 421,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 5, 25, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 16, 3, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 422,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 30, 2, 30, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 19, 49, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 423,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 14, 18, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 13, 25, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 424,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 2, 12, 40, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 3, 13, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 425,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 17, 33, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 1, 25, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 426,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 19, 2, 43, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 18, 29, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 427,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 0, 28, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 23, 4, 16, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 428,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 4, 47, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 12, 51, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 429,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 20, 12, 28, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 22, 1, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 430,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 17, 11, 56, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 19, 31, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 431,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 2, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 11, 31, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 432,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 18, 21, 5, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 5, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 433,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 9, 22, 5, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 18, 8, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 434,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 12, 14, 1, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 10, 18, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 435,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 5, 50, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 4, 57, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 436,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 22, 19, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 17, 52, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 437,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 23, 0, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 13, 23, 30, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 438,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 3, 26, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 5, 48, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 439,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 31, 18, 51, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 17, 32, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 440,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 20, 9, 47, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 21, 25, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 441,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 5, 36, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 30, 15, 3, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 442,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 4, 19, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 10, 42, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 443,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 28, 15, 43, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 15, 14, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 444,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 22, 21, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 15, 20, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 445,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 20, 8, 47, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 9, 5, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 446,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 7, 13, 14, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 3, 9, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 447,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 3, 31, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 11, 35, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 448,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 17, 27, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 19, 49, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 449,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 18, 21, 43, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 20, 39, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 450,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 17, 56, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 10, 48, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 451,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 23, 28, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 17, 49, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 452,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 7, 5, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 5, 58, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 453,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 12, 45, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 16, 59, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 454,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 1, 39, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 12, 28, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 455,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 28, 5, 30, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 12, 15, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 456,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 21, 1, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 3, 52, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 457,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 28, 18, 37, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 4, 8, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 458,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 10, 32, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 3, 25, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 459,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 5, 16, 10, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 13, 28, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 460,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 8, 50, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 11, 18, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 461,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 4, 45, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 0, 36, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 462,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 9, 21, 7, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 3, 17, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 463,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 11, 3, 36, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 23, 36, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 464,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 23, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 4, 44, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 465,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 2, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 9, 58, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 466,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 27, 6, 17, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 13, 3, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 467,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 1, 26, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 8, 50, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 468,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 8, 47, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 2, 36, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 469,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 0, 7, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 13, 12, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 470,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 0, 25, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 1, 32, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 471,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 23, 32, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 15, 25, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 472,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 13, 57, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 9, 32, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 473,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 17, 1, 52, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 13, 1, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 474,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 18, 54, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 2, 59, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 475,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 43, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 11, 6, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 476,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 10, 4, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 23, 42, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 477,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 21, 41, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 15, 23, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 478,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 1, 6, 5, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 13, 34, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 479,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 30, 18, 51, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 12, 3, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 480,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 20, 58, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 3, 23, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 481,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 4, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 9, 11, 41, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 482,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 10, 8, 49, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 6, 54, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 483,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 16, 29, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 23, 10, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 484,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 2, 23, 14, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 23, 19, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 485,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 6, 41, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 4, 11, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 486,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 11, 36, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 2, 37, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 487,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 13, 19, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 7, 17, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 488,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 15, 3, 42, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 4, 32, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 489,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 4, 21, 8, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 11, 18, 8, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 490,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 1, 21, 51, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 0, 41, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 491,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 10, 30, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 2, 34, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 492,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 8, 20, 39, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 17, 40, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 493,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 12, 51, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 3, 19, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 494,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 5, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 2, 57, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 495,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 21, 7, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 22, 43, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 496,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 4, 22, 25, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 20, 51, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 497,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 31, 0, 39, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 11, 27, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 498,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 17, 51, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 4, 19, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 499,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 17, 0, 12, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 16, 23, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 500,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 10, 36, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 17, 10, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 501,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 26, 1, 32, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 15, 30, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 502,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 13, 42, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 0, 58, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 503,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 18, 29, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 15, 34, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 504,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 7, 0, 41, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 3, 58, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 505,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 21, 1, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 5, 2, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 506,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 3, 0, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 6, 21, 39, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 507,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 6, 45, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 18, 7, 35, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 508,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 6, 6, 28, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 23, 42, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 509,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 18, 25, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 1, 19, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 510,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 17, 37, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 0, 35, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 511,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 12, 19, 11, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 5, 31, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 512,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 3, 53, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 9, 38, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 513,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 12, 2, 25, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 4, 30, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 514,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 8, 18, 1, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 13, 21, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 515,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 8, 19, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 20, 42, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 516,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 5, 6, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 13, 16, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 517,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 22, 19, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 8, 38, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 518,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 17, 49, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 6, 31, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 519,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 6, 47, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 22, 19, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 520,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 12, 20, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 19, 54, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 521,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 7, 20, 28, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 22, 15, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 522,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 5, 32, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 1, 18, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 523,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 31, 12, 10, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 12, 52, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 524,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 20, 2, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 21, 17, 17, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 525,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 30, 11, 39, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 3, 19, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 526,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 20, 7, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 16, 43, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 527,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 2, 58, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 10, 22, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 528,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 17, 9, 8, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 10, 15, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 529,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 14, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 5, 5, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 530,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 6, 0, 35, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 7, 1, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 531,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 17, 6, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 9, 11, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 532,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 1, 14, 54, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 10, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 533,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 11, 30, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 16, 54, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 534,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 22, 36, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 23, 58, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 535,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 10, 13, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 22, 12, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 536,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 8, 34, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 20, 53, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 537,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 18, 20, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 15, 56, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 538,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 18, 0, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 12, 44, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 539,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 13, 17, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 9, 1, 9, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 540,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 30, 20, 51, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 15, 29, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 541,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 18, 48, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 22, 26, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 542,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 25, 18, 50, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 3, 40, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 543,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 1, 16, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 21, 31, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 544,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 19, 5, 28, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 17, 35, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 545,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 21, 5, 26, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 11, 58, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 546,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 17, 12, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 21, 27, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 547,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 3, 11, 16, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 13, 43, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 548,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 22, 5, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 2, 46, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 549,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 27, 7, 49, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 1, 50, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 550,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 21, 23, 53, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 19, 12, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 551,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 9, 45, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 14, 6, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 552,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 8, 4, 15, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 17, 51, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 553,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 11, 48, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 8, 49, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 554,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 23, 3, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 23, 32, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 555,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 3, 31, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 10, 23, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 556,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 11, 16, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 17, 30, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 557,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 9, 16, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 8, 41, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 558,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 1, 50, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 23, 39, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 559,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 2, 37, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 22, 11, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 560,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 17, 15, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 11, 8, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 561,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 29, 1, 49, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 23, 5, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 562,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 6, 47, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 10, 19, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 563,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 17, 49, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 19, 17, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 564,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 11, 17, 29, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 0, 18, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 565,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 9, 20, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 6, 20, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 566,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 12, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 4, 20, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 567,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 13, 43, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 16, 35, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 568,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 6, 18, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 13, 51, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 569,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 18, 23, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 6, 30, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 570,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 3, 56, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 0, 48, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 571,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 22, 13, 46, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 16, 49, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 572,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 20, 21, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 11, 5, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 573,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 17, 12, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 21, 53, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 574,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 9, 37, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 2, 49, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 575,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 11, 1, 18, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 5, 3, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 576,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 6, 0, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 7, 37, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 577,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 1, 13, 20, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 1, 22, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 578,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 11, 7, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 10, 5, 11, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 579,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 23, 49, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 22, 56, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 580,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 22, 34, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 14, 19, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 581,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 18, 22, 40, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 10, 4, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 582,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 7, 12, 55, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 3, 50, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 583,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 10, 8, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 7, 44, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 584,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 17, 20, 36, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 7, 25, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 585,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 6, 18, 32, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 17, 38, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 586,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 8, 44, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 6, 53, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 587,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 14, 48, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 12, 50, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 588,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 2, 16, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 1, 19, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 589,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 14, 43, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 21, 0, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 590,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 7, 2, 18, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 1, 8, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 591,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 11, 28, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 8, 16, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 592,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 1, 7, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 29, 5, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 593,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 18, 52, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 21, 33, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 594,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 21, 45, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 23, 58, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 595,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 3, 53, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 8, 50, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 596,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 19, 17, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 14, 19, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 597,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 10, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 23, 58, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 598,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 30, 5, 5, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 2, 17, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 599,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 6, 6, 27, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 8, 40, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 600,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 10, 8, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 13, 1, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 601,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 21, 19, 4, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 20, 8, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 602,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 31, 3, 3, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 10, 12, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 603,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 9, 59, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 22, 35, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 604,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 4, 39, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 10, 36, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 605,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 17, 58, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 1, 27, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 606,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 13, 14, 21, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 2, 34, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 607,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 18, 32, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 3, 2, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 608,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 17, 7, 42, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 17, 59, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 609,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 17, 44, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 3, 55, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 610,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 4, 55, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 15, 23, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 611,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 13, 16, 11, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 11, 31, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 612,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 22, 26, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 9, 11, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 613,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 16, 17, 7, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 4, 51, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 614,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 59, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 18, 49, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 615,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 20, 25, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 3, 2, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 616,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 9, 22, 30, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 1, 47, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 617,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 15, 18, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 0, 6, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 618,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 2, 51, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 17, 40, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 619,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 20, 51, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 3, 41, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 620,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 18, 14, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 5, 59, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 621,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 16, 50, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 1, 50, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 622,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 19, 11, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 3, 1, 36, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 623,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 20, 49, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 16, 37, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 624,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 7, 3, 21, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 9, 20, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 625,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 30, 6, 8, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 15, 18, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 626,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 0, 1, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 9, 21, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 627,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 29, 13, 41, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 21, 49, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 628,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 20, 39, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 17, 3, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 629,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 9, 46, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 20, 34, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 630,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 1, 46, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 6, 37, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 631,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 18, 2, 7, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 10, 28, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 632,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 18, 26, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 3, 48, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 633,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 15, 52, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 3, 59, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 634,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 7, 28, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 22, 2, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 635,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 17, 16, 23, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 17, 25, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 636,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 29, 17, 27, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 12, 56, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 637,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 23, 23, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 12, 22, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 638,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 1, 58, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 3, 18, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 639,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 3, 2, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 11, 54, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 640,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 13, 12, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 23, 51, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 641,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 21, 18, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 18, 19, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 642,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 30, 15, 23, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 5, 9, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 643,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 25, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 6, 25, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 644,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 10, 2, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 6, 57, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 645,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 19, 18, 19, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 13, 1, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 646,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 9, 33, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 15, 22, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 647,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 7, 19, 25, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 1, 46, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 648,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 10, 0, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 19, 55, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 649,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 9, 14, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 21, 48, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 650,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 5, 46, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 19, 46, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 651,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 4, 57, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 4, 23, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 652,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 10, 5, 42, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 10, 41, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 653,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 5, 26, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 2, 21, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 654,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 31, 9, 46, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 15, 32, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 655,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 15, 21, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 19, 43, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 656,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 11, 3, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 1, 41, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 657,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 2, 40, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 9, 50, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 658,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 11, 0, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 13, 40, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 659,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 18, 40, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 15, 42, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 660,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 9, 6, 55, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 7, 44, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 661,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 19, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 4, 30, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 662,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 26, 2, 25, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 15, 1, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 663,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 2, 12, 40, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 12, 26, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 664,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 17, 41, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 2, 46, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 665,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 9, 3, 28, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 21, 53, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 666,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 21, 40, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 21, 41, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 667,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 11, 37, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 7, 24, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 668,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 16, 33, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 1, 7, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 669,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 15, 42, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 19, 18, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 670,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 20, 20, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 8, 27, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 671,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 7, 30, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 4, 17, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 672,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 2, 9, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 14, 7, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 673,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 16, 1, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 16, 36, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 674,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 5, 7, 11, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 16, 44, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 675,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 8, 30, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 13, 44, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 676,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 3, 22, 25, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 1, 36, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 677,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 31, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 0, 36, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 678,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 19, 55, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 7, 42, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 679,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 13, 14, 52, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 3, 10, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 680,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 3, 26, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 6, 32, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 681,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 30, 2, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 0, 34, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 682,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 19, 4, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 15, 21, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 683,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 22, 24, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 19, 33, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 684,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 10, 55, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 22, 30, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 685,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 21, 29, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 6, 22, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 686,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 9, 14, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 19, 25, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 687,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 5, 22, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 13, 35, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 688,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 15, 0, 17, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 24, 3, 15, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 689,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 5, 38, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 1, 59, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 690,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 54, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 8, 7, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 691,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 19, 27, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 4, 27, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 692,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 17, 55, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 4, 40, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 693,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 9, 29, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 14, 20, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 694,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 18, 1, 9, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 9, 57, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 695,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 3, 53, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 11, 41, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 696,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 22, 6, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 22, 1, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 697,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 20, 27, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 19, 23, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 698,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 14, 2, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 2, 10, 18, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 699,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 12, 8, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 21, 36, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 700,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 21, 14, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 0, 30, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 701,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 11, 1, 34, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 2, 35, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 702,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 4, 2, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 20, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 703,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 18, 23, 46, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 24, 16, 6, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 704,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 14, 23, 30, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 2, 9, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 705,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 12, 31, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 11, 48, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 706,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 21, 23, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 2, 29, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 707,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 1, 42, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 15, 43, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 708,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 10, 24, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 17, 8, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 709,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 17, 11, 48, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 2, 56, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 710,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 9, 32, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 8, 9, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 711,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 8, 13, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 11, 30, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 712,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 11, 35, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 10, 39, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 713,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 1, 3, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 19, 56, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 714,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 0, 47, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 5, 9, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 715,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 13, 25, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 10, 7, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 716,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 12, 3, 44, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 19, 44, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 717,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 20, 46, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 13, 35, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 718,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 26, 21, 3, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 6, 21, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 719,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 16, 25, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 16, 35, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 720,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 3, 20, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 12, 48, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 721,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 11, 19, 55, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 12, 38, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 722,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 11, 16, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 18, 35, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 723,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 1, 11, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 1, 33, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 724,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 19, 10, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 11, 37, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 725,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 23, 17, 14, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 3, 38, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 726,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 2, 54, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 0, 23, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 727,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 3, 32, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 4, 1, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 728,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 24, 1, 11, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 0, 57, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 729,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 13, 13, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 2, 6, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 730,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 5, 6, 15, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 22, 30, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 731,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 2, 43, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 12, 51, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 732,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 39, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 13, 33, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 733,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 17, 38, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 13, 25, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 734,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 1, 37, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 18, 36, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 735,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 0, 21, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 9, 38, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 736,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 19, 3, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 4, 16, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 737,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 20, 9, 1, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 14, 44, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 738,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 0, 14, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 16, 7, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 739,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 7, 12, 2, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 15, 56, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 740,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 27, 6, 46, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 4, 50, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 741,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 28, 15, 38, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 17, 17, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 742,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 1, 58, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 22, 0, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 743,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 19, 19, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 20, 8, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 744,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 13, 13, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 12, 57, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 745,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 29, 12, 31, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 3, 41, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 746,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 7, 0, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 23, 47, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 747,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 1, 32, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 0, 14, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 748,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 2, 24, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 6, 27, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 749,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 9, 52, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 19, 54, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 750,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 19, 30, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 15, 24, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 751,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 9, 32, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 1, 28, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 752,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 8, 53, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 6, 44, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 753,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 1, 32, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 18, 40, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 754,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 6, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 22, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 755,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 48, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 21, 57, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 756,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 9, 39, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 14, 31, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 757,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 6, 11, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 19, 5, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 758,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 24, 14, 29, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 12, 47, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 759,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 11, 5, 56, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 9, 28, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 760,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 15, 33, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 12, 12, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 761,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 20, 58, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 23, 19, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 762,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 11, 54, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 5, 52, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 763,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 5, 42, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 7, 24, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 764,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 23, 19, 47, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 17, 26, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 765,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 11, 12, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 0, 40, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 766,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 5, 19, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 7, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 767,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 23, 9, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 8, 43, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 768,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 11, 2, 27, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 16, 3, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 769,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 29, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 14, 1, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 770,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 21, 23, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 10, 30, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 771,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 29, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 23, 46, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 772,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 19, 19, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 1, 37, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 773,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 49, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 17, 17, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 774,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 4, 57, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 0, 23, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 775,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 1, 19, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 17, 34, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 776,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 20, 0, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 15, 12, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 777,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 8, 21, 44, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 8, 14, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 778,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 20, 24, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 16, 44, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 779,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 8, 3, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 13, 9, 9, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 780,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 3, 2, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 22, 29, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 781,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 10, 57, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 22, 1, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 782,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 23, 53, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 3, 20, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 783,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 9, 14, 14, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 3, 3, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 784,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 8, 17, 41, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 3, 3, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 785,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 13, 8, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 12, 30, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 786,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 14, 51, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 2, 56, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 787,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 20, 13, 33, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 9, 37, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 788,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 0, 18, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 4, 37, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 789,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 7, 0, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 5, 54, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 790,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 18, 3, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 19, 1, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 791,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 31, 23, 26, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 11, 47, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 792,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 16, 19, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 6, 46, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 793,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 2, 0, 51, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 13, 30, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 794,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 4, 21, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 21, 27, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 795,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 15, 52, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 6, 51, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 796,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 23, 29, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 797,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 13, 19, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 14, 45, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 798,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 21, 17, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 7, 18, 37, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 799,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 52, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 21, 36, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 800,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 0, 11, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 3, 43, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 801,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 11, 55, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 5, 9, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 802,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 12, 7, 50, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 13, 43, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 803,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 3, 39, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 10, 3, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 804,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 9, 29, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 8, 59, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 805,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 8, 7, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 4, 38, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 806,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 13, 53, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 6, 0, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 807,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 18, 15, 22, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 12, 32, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 808,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 20, 14, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 3, 12, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 809,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 11, 20, 38, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 9, 57, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 810,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 1, 33, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 1, 58, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 811,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 40, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 16, 38, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 812,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 5, 16, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 20, 44, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 813,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 21, 8, 10, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 12, 51, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 814,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 21, 22, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 5, 2, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 815,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 23, 1, 44, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 2, 13, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 816,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 26, 11, 28, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 16, 57, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 817,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 8, 10, 51, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 14, 33, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 818,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 21, 31, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 19, 10, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 819,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 8, 16, 30, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 14, 2, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 820,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 2, 19, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 23, 18, 33, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 821,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 20, 15, 58, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 14, 11, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 822,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 18, 11, 7, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 10, 1, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 823,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 8, 43, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 4, 18, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 824,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 10, 55, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 15, 32, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 825,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 20, 41, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 17, 0, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 826,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 26, 4, 22, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 9, 4, 10, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 827,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 6, 36, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 17, 13, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 828,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 1, 4, 24, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 5, 30, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 829,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 19, 29, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 20, 20, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 830,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 12, 9, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 23, 34, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 831,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 18, 24, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 21, 55, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 832,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 1, 14, 41, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 16, 2, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 833,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 8, 45, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 12, 56, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 834,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 20, 40, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 0, 39, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 835,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 16, 45, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 8, 0, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 836,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 25, 6, 42, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 22, 47, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 837,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 7, 14, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 4, 2, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 838,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 17, 14, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 11, 39, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 839,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 16, 24, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 19, 37, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 840,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 17, 30, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 23, 46, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 841,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 4, 7, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 20, 8, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 842,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 20, 47, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 16, 55, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 843,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 8, 14, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 22, 35, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 844,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 0, 32, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 20, 40, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 845,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 31, 0, 39, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 15, 48, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 846,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 13, 14, 54, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 21, 58, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 847,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 5, 59, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 5, 53, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 848,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 18, 9, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 18, 8, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 849,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 22, 3, 36, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 16, 39, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 850,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 13, 1, 44, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 9, 19, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 851,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 6, 0, 41, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 0, 2, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 852,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 20, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 4, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 853,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 12, 23, 36, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 11, 18, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 854,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 21, 20, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 11, 21, 24, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 855,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 24, 9, 2, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 21, 48, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 856,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 17, 13, 0, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 4, 37, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 857,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 3, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 23, 26, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 858,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 6, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 12, 9, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 859,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 15, 22, 50, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 5, 23, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 860,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 14, 45, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 7, 3, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 861,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 29, 10, 28, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 12, 25, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 862,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 17, 1, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 18, 37, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 863,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 24, 10, 29, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 1, 53, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 864,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 1, 9, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 7, 45, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 865,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 11, 3, 38, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 14, 21, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 866,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 8, 42, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 7, 8, 50, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 867,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 27, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 17, 41, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 868,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 13, 6, 10, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 12, 1, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 869,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 10, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 16, 1, 15, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 870,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 0, 58, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 14, 4, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 871,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 30, 7, 25, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 20, 8, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 872,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 8, 15, 25, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 12, 3, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 873,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 8, 18, 51, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 9, 55, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 874,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 23, 55, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 0, 2, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 875,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 8, 3, 9, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 17, 25, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 876,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 12, 22, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 14, 33, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 877,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 2, 14, 14, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 7, 7, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 878,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 23, 29, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 15, 58, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 879,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 20, 18, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 9, 57, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 880,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 11, 50, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 12, 55, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 881,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 18, 55, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 21, 41, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 882,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 25, 6, 41, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 1, 26, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 883,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 11, 55, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 21, 58, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 884,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 19, 7, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 12, 59, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 885,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 9, 47, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 5, 21, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 886,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 20, 58, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 9, 17, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 887,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 24, 21, 37, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 2, 9, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 888,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 16, 38, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 20, 32, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 889,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 3, 1, 24, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 18, 25, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 890,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 8, 27, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 17, 53, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 891,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 9, 56, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 13, 47, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 892,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 3, 11, 3, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 15, 19, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 893,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 21, 3, 3, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 19, 24, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 894,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 0, 26, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 1, 25, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 895,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 31, 9, 38, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 5, 40, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 896,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 15, 35, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 21, 55, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 897,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 5, 50, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 21, 12, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 898,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 13, 3, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 4, 32, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 899,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 3, 3, 43, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 9, 53, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 900,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 11, 46, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 2, 18, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 901,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 7, 18, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 4, 13, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 902,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 22, 17, 34, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 0, 17, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 903,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 30, 17, 34, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 22, 43, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 904,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 13, 17, 23, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 8, 36, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 905,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 6, 1, 54, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 20, 21, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 906,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 1, 22, 48, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 8, 27, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 907,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 16, 1, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 18, 57, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 908,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 9, 54, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 8, 35, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 909,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 12, 57, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 19, 43, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 910,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 25, 7, 28, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 18, 28, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 911,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 43, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 8, 9, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 912,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 22, 22, 8, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 21, 29, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 913,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 7, 55, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 10, 54, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 914,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 4, 18, 18, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 11, 5, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 915,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 14, 27, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 4, 40, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 916,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 24, 10, 14, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 4, 48, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 917,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 11, 37, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 4, 45, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 918,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 0, 29, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 6, 16, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 919,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 8, 11, 16, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 19, 54, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 920,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 13, 22, 3, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 20, 20, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 921,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 8, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 3, 49, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 922,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 6, 21, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 14, 39, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 923,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 12, 39, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 11, 21, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 924,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 26, 11, 24, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 17, 42, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 925,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 18, 17, 59, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 13, 36, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 926,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 26, 9, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 2, 22, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 927,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 4, 49, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 21, 43, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 928,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 6, 15, 8, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 6, 48, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 929,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 16, 53, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 15, 43, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 930,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 6, 50, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 0, 41, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 931,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 23, 37, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 18, 24, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 932,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 9, 30, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 6, 0, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 933,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 9, 1, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 22, 49, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 934,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 26, 12, 46, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 20, 16, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 935,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 7, 21, 44, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 18, 52, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 936,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 3, 28, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 21, 25, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 937,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 7, 0, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 6, 3, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 938,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 5, 7, 52, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 11, 0, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 939,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 17, 14, 59, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 14, 42, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 940,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 14, 14, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 5, 3, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 941,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 3, 37, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 8, 29, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 942,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 21, 23, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 21, 27, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 943,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 1, 11, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 8, 46, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 944,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 11, 15, 11, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 6, 41, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 945,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 1, 5, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 17, 7, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 946,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 19, 35, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 3, 12, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 947,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 40, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 4, 29, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 948,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 21, 40, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 0, 54, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 949,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 20, 19, 43, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 23, 52, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 950,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 10, 46, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 17, 12, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 951,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 11, 14, 31, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 17, 46, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 952,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 30, 13, 58, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 0, 47, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 953,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 20, 39, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 8, 18, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 954,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 4, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 7, 14, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 955,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 2, 11, 8, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 14, 8, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 956,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 7, 11, 11, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 5, 28, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 957,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 18, 10, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 16, 54, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 958,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 12, 16, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 19, 46, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 959,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 9, 53, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 13, 32, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 960,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 15, 14, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 26, 19, 25, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 961,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 0, 16, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 21, 22, 0, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 962,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 5, 7, 8, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 2, 14, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 963,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 19, 32, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 8, 39, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 964,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 16, 37, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 0, 26, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 965,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 21, 42, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 16, 56, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 966,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 31, 3, 29, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 8, 57, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 967,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 31, 10, 53, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 4, 18, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 968,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 6, 19, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 5, 53, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 969,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 9, 23, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 6, 24, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 970,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 0, 29, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 15, 25, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 971,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 24, 4, 4, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 23, 47, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 972,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 12, 7, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 17, 25, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 973,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 25, 20, 11, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 8, 24, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 974,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 13, 14, 28, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 17, 7, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 975,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 8, 19, 57, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 5, 52, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 976,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 31, 18, 58, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 23, 0, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 977,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 3, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 2, 7, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 978,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 11, 2, 14, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 9, 54, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 979,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 12, 32, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 22, 1, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 980,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 3, 14, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 11, 10, 16, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 981,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 19, 4, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 8, 22, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 982,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 17, 41, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 11, 13, 17, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 983,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 29, 23, 14, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 4, 8, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 984,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 5, 33, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 11, 32, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 985,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 28, 1, 24, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 11, 26, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 986,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 23, 0, 36, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 3, 42, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 987,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 7, 23, 11, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 15, 21, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 988,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 29, 23, 21, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 2, 11, 33, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 989,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 7, 12, 26, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 20, 22, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 990,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 8, 25, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 21, 1, 13, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 991,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 2, 2, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 1, 50, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 992,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 22, 58, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 23, 47, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 993,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 18, 36, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 2, 48, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 994,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 26, 19, 49, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 0, 47, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 995,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 19, 8, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 4, 37, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 996,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 12, 15, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 2, 39, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 997,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 17, 4, 34, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 17, 31, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 998,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 22, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 7, 1, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 999,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 7, 37, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 12, 1, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 1000,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 11, 36, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 6, 30, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 21, 35, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 8, 23, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 15, 50, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 21, 31, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 14, 5, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 8, 5, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 7, 1, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 2, 38, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 14, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 8, 32, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 19, 9, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 18, 14, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 1, 40, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 17, 27, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 19, 17, 48, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 1, 57, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 21, 29, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 22, 46, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 0, 2, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 18, 47, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 7, 9, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 9, 56, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 13, 11, 44, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 22, 18, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 28, 21, 31, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 0, 21, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 2, 3, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 4, 56, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 33, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 11, 59, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 2, 58, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 7, 22, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 1, 5, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 19, 44, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 3, 22, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 16, 51, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 15, 3, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 10, 20, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 4, 53, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 9, 13, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 9, 5, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 14, 35, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 22,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 0, 24, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 7, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 23,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 18, 26, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 3, 42, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 24,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 4, 46, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 6, 35, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 25,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 26, 22, 2, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 23, 38, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 26,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 17, 4, 29, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 10, 49, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 27,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 1, 40, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 2, 24, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 28,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 19, 51, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 20, 34, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 29,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 15, 34, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 16, 27, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 30,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 3, 7, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 0, 28, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 31,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 25, 23, 31, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 1, 19, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 32,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 13, 39, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 9, 25, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 33,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 27, 3, 30, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 15, 9, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 34,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 11, 49, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 1, 13, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 35,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 10, 29, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 2, 15, 24, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 36,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 10, 8, 2, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 9, 10, 49, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 37,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 28, 22, 29, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 11, 8, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 38,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 20, 58, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 10, 9, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 39,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 11, 8, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 11, 12, 53, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 40,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 17, 9, 59, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 16, 35, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 41,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 7, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 6, 16, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 42,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 13, 4, 14, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 22, 50, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 43,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 35, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 21, 12, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 44,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 5, 46, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 21, 34, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 45,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 3, 11, 48, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 18, 18, 46, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 46,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 24, 5, 28, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 21, 1, 19, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 47,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 18, 27, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 18, 26, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 48,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 13, 3, 4, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 0, 31, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 49,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 23, 17, 36, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 14, 42, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 50,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 6, 25, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 22, 38, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 51,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 23, 12, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 1, 58, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 52,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 6, 12, 21, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 22, 27, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 53,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 0, 10, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 9, 2, 34, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 54,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 0, 50, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 10, 14, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 55,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 18, 4, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 31, 20, 27, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 56,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 23, 10, 9, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 2, 4, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 57,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 12, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 20, 59, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 58,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 21, 36, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 3, 8, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 59,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 19, 0, 37, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 6, 55, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 60,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 16, 55, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 21, 58, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 61,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 26, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 11, 48, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 62,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 8, 23, 39, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 2, 7, 41, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 63,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 1, 1, 15, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 7, 40, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 64,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 29, 21, 47, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 16, 10, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 65,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 8, 13, 48, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 4, 55, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 66,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 17, 11, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 20, 38, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 67,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 30, 1, 30, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 0, 16, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 68,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 16, 30, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 9, 31, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 69,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 20, 8, 44, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 30, 15, 47, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 70,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 0, 18, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 13, 42, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 71,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 14, 3, 2, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 11, 44, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 72,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 28, 17, 18, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 0, 37, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 73,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 3, 10, 59, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 17, 16, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 74,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 30, 8, 28, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 16, 9, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 75,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 14, 16, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 18, 18, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 76,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 21, 33, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 5, 25, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 77,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 20, 9, 5, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 1, 13, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 78,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 13, 12, 43, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 21, 12, 18, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 79,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 6, 12, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 2, 48, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 80,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 8, 10, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 2, 34, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 81,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 3, 43, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 8, 52, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 82,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 20, 15, 27, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 8, 7, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 83,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 9, 15, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 5, 59, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 84,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 31, 11, 16, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 6, 22, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 85,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 19, 45, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 4, 52, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 86,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 14, 53, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 5, 50, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 87,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 20, 15, 25, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 13, 0, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 88,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 7, 54, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 2, 7, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 89,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 8, 13, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 22, 22, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 90,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 22, 5, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 1, 23, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 91,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 1, 16, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 18, 58, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 92,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 3, 15, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 11, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 93,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 16, 26, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 16, 41, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 94,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 1, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 21, 43, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 95,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 13, 1, 41, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 3, 27, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 96,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 1, 11, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 19, 0, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 97,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 21, 8, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 2, 50, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 98,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 23, 15, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 14, 38, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 99,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 1, 40, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 1, 41, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 100,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 21, 12, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 5, 2, 30, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 101,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 22, 14, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 4, 13, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 102,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 17, 22, 2, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 15, 32, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 103,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 20, 2, 1, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 5, 55, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 104,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 9, 51, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 21, 4, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 105,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 4, 3, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 16, 58, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 106,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 18, 40, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 20, 24, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 107,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 23, 6, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 17, 36, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 108,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 8, 41, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 21, 26, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 109,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 8, 42, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 15, 52, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 110,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 11, 33, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 9, 17, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 111,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 2, 53, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 11, 12, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 112,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 27, 8, 45, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 22, 4, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 113,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 22, 0, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 19, 10, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 114,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 5, 31, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 17, 54, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 115,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 28, 9, 19, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 11, 10, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 116,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 9, 10, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 15, 49, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 117,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 4, 5, 30, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 10, 10, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 118,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 9, 54, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 0, 12, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 119,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 4, 12, 15, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 7, 28, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 120,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 21, 5, 57, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 22, 26, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 121,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 23, 19, 22, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 23, 3, 11, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 122,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 24, 10, 48, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 2, 52, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 123,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 2, 52, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 23, 13, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 124,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 30, 17, 26, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 16, 26, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 125,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 12, 0, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 23, 8, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 126,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 4, 24, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 23, 16, 40, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 127,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 9, 14, 6, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 23, 4, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 128,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 21, 17, 33, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 16, 25, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 129,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 9, 48, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 17, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 130,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 29, 14, 4, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 6, 10, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 131,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 9, 6, 32, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 18, 30, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 132,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 23, 53, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 21, 33, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 133,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 3, 4, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 20, 6, 4, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 134,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 1, 40, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 18, 56, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 135,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 7, 0, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 22, 6, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 136,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 8, 6, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 15, 29, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 137,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 23, 48, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 0, 43, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 138,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 9, 39, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 16, 40, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 139,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 21, 13, 31, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 21, 0, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 140,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 3, 55, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 9, 7, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 141,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 26, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 23, 17, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 142,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 11, 42, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 14, 14, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 143,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 3, 21, 58, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 9, 14, 47, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 144,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 6, 15, 11, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 9, 34, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 145,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 6, 51, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 23, 39, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 146,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 49, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 23, 9, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 147,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 11, 14, 48, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 11, 15, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 148,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 21, 9, 51, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 13, 5, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 149,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 30, 6, 46, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 29, 5, 2, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 150,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 8, 6, 48, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 7, 48, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 151,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 10, 40, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 4, 59, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 152,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 23, 55, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 14, 52, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 153,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 13, 58, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 17, 57, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 154,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 15, 12, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 1, 2, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 155,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 11, 1, 29, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 23, 6, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 156,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 23, 52, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 0, 49, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 157,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 17, 54, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 21, 48, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 158,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 17, 19, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 0, 31, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 159,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 22, 9, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 3, 17, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 160,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 23, 44, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 19, 24, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 161,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 31, 11, 40, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 20, 26, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 162,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 13, 56, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 20, 42, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 163,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 13, 20, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 2, 27, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 164,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 6, 19, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 10, 32, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 165,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 14, 53, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 1, 10, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 166,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 13, 26, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 21, 3, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 167,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 20, 6, 40, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 3, 31, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 168,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 18, 50, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 23, 9, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 169,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 3, 10, 43, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 14, 29, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 170,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 13, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 29, 5, 31, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 171,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 16, 34, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 10, 24, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 172,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 5, 38, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 31, 11, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 173,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 20, 45, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 7, 54, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 174,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 8, 47, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 17, 28, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 175,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 20, 38, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 5, 31, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 176,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 11, 5, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 7, 15, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 177,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 11, 59, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 23, 11, 0, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 178,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 26, 6, 48, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 9, 0, 42, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 179,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 30, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 5, 33, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 180,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 18, 23, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 15, 13, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 181,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 30, 0, 21, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 8, 17, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 182,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 24, 22, 53, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 19, 3, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 183,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 1, 13, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 11, 43, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 184,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 4, 57, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 16, 31, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 185,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 10, 29, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 21, 42, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 186,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 29, 1, 24, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 22, 7, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 187,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 13, 1, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 23, 30, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 188,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 12, 15, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 2, 20, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 189,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 29, 19, 29, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 12, 30, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 190,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 5, 27, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 13, 48, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 191,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 22, 41, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 1, 40, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 192,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 11, 12, 15, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 2, 40, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 193,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 9, 6, 17, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 1, 31, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 194,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 7, 0, 53, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 12, 42, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 195,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 22, 3, 39, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 23, 51, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 196,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 0, 13, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 17, 16, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 197,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 18, 21, 1, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 22, 59, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 198,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 11, 0, 13, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 12, 35, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 199,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 1, 11, 22, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 16, 28, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 200,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 17, 21, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 12, 26, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 201,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 2, 1, 48, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 1, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 202,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 17, 7, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 17, 43, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 203,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 20, 30, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 15, 25, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 204,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 7, 2, 12, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 16, 9, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 205,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 19, 7, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 3, 19, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 206,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 20, 16, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 7, 50, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 207,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 7, 10, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 8, 57, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 208,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 11, 25, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 19, 9, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 209,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 7, 3, 27, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 18, 22, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 210,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 12, 40, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 16, 14, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 211,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 12, 14, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 0, 29, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 212,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 11, 20, 29, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 9, 45, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 213,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 5, 28, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 9, 11, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 214,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 20, 1, 35, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 23, 18, 14, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 215,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 23, 19, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 8, 24, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 216,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 29, 12, 52, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 20, 22, 24, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 217,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 9, 23, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 18, 26, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 218,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 13, 35, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 20, 7, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 219,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 20, 38, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 1, 46, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 220,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 30, 19, 48, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 8, 23, 41, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 221,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 23, 24, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 14, 20, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 222,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 15, 4, 40, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 17, 51, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 223,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 1, 10, 8, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 21, 0, 15, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 224,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 47, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 6, 38, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 225,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 20, 2, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 8, 18, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 226,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 7, 4, 15, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 16, 41, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 227,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 12, 2, 20, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 8, 6, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 228,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 3, 23, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 19, 19, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 229,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 16, 30, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 14, 48, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 230,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 30, 18, 41, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 19, 51, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 231,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 1, 52, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 18, 29, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 232,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 5, 1, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 8, 50, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 233,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 24, 10, 19, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 14, 21, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 234,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 9, 10, 26, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 18, 20, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 235,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 21, 34, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 13, 13, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 236,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 17, 11, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 3, 56, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 237,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 7, 15, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 4, 33, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 238,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 4, 53, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 10, 19, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 239,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 11, 12, 23, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 14, 8, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 240,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 20, 51, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 13, 40, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 241,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 27, 20, 44, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 17, 56, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 242,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 19, 7, 56, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 15, 39, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 243,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 1, 3, 15, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 0, 8, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 244,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 19, 19, 26, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 9, 57, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 245,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 1, 47, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 2, 12, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 246,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 11, 9, 40, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 0, 39, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 247,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 20, 52, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 5, 46, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 248,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 13, 9, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 16, 54, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 249,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 18, 2, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 8, 29, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 250,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 24, 15, 48, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 23, 12, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 251,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 12, 29, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 8, 7, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 252,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 13, 11, 7, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 8, 21, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 253,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 46, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 12, 9, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 254,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 7, 52, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 19, 18, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 255,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 19, 27, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 18, 46, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 256,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 18, 45, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 22, 49, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 257,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 17, 20, 19, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 21, 1, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 258,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 9, 22, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 6, 46, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 259,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 14, 28, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 4, 13, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 260,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 18, 12, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 22, 6, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 261,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 22, 50, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 15, 4, 29, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 262,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 18, 54, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 3, 2, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 263,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 21, 22, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 7, 3, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 264,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 11, 44, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 9, 33, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 265,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 17, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 9, 54, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 266,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 5, 23, 34, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 3, 44, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 267,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 8, 13, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 18, 12, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 268,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 1, 31, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 8, 20, 31, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 269,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 13, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 20, 33, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 270,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 27, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 4, 20, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 271,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 18, 56, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 3, 58, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 272,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 3, 10, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 20, 6, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 273,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 4, 36, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 17, 57, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 274,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 3, 1, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 20, 32, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 275,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 24, 5, 9, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 6, 48, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 276,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 6, 3, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 23, 29, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 277,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 3, 26, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 16, 4, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 278,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 33, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 12, 12, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 279,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 3, 41, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 11, 15, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 280,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 21, 15, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 9, 28, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 281,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 23, 4, 50, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 30, 21, 26, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 282,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 6, 10, 23, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 7, 55, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 283,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 4, 19, 51, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 17, 39, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 284,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 22, 11, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 12, 47, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 285,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 21, 17, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 16, 9, 18, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 286,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 12, 0, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 17, 12, 10, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 287,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 2, 28, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 6, 39, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 288,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 17, 22, 23, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 22, 30, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 289,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 3, 19, 55, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 22, 47, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 290,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 4, 1, 50, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 22, 44, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 291,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 15, 11, 4, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 18, 22, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 292,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 13, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 17, 32, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 293,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 21, 33, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 11, 27, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 294,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 24, 10, 9, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 5, 16, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 295,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 12, 13, 11, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 14, 39, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 296,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 4, 59, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 13, 7, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 297,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 10, 37, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 19, 14, 54, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 298,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 3, 11, 34, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 15, 2, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 299,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 22, 52, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 17, 8, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 300,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 12, 1, 41, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 5, 21, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 301,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 10, 16, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 4, 5, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 302,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 13, 9, 25, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 23, 38, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 303,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 13, 5, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 14, 2, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 304,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 18, 3, 3, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 14, 16, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 305,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 5, 50, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 2, 37, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 306,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 25, 12, 53, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 23, 31, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 307,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 5, 8, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 4, 7, 26, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 308,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 10, 0, 47, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 15, 19, 23, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 309,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 13, 5, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 2, 28, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 310,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 2, 14, 8, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 14, 35, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 311,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 13, 11, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 12, 46, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 312,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 8, 6, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 12, 32, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 313,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 3, 21, 6, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 11, 18, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 314,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 17, 46, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 11, 19, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 315,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 25, 19, 24, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 20, 4, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 316,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 16, 3, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 21, 17, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 317,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 10, 18, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 12, 36, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 318,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 21, 45, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 8, 0, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 319,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 17, 55, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 20, 44, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 320,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 23, 8, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 19, 44, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 321,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 8, 23, 46, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 5, 40, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 322,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 26, 13, 34, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 23, 13, 22, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 323,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 5, 14, 51, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 3, 59, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 324,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 9, 28, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 7, 11, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 325,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 16, 28, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 11, 32, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 326,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 5, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 3, 34, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 327,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 27, 8, 36, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 10, 3, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 328,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 13, 17, 35, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 12, 21, 34, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 329,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 1, 30, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 16, 4, 14, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 330,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 12, 13, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 17, 26, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 331,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 12, 14, 9, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 27, 17, 54, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 332,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 7, 29, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 16, 33, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 333,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 10, 40, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 22, 32, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 334,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 28, 22, 27, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 5, 35, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 335,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 7, 30, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 18, 28, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 336,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 12, 21, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 22, 38, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 337,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 22, 18, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 11, 45, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 338,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 10, 8, 55, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 2, 48, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 339,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 20, 21, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 17, 6, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 340,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 5, 49, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 9, 27, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 341,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 19, 8, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 17, 34, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 342,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 23, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 8, 15, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 343,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 23, 28, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 9, 39, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 344,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 4, 28, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 6, 10, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 345,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 21, 53, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 13, 5, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 346,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 11, 53, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 17, 23, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 347,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 3, 49, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 12, 41, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 348,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 2, 39, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 15, 8, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 349,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 33, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 20, 38, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 350,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 57, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 10, 9, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 351,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 14, 37, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 9, 7, 4, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 352,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 6, 12, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 8, 40, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 353,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 27, 14, 32, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 2, 4, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 354,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 25, 21, 3, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 17, 1, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 355,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 5, 46, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 9, 19, 38, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 356,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 22, 29, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 11, 15, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 357,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 15, 6, 6, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 3, 8, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 358,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 11, 8, 17, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 6, 0, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 359,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 28, 3, 6, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 19, 34, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 360,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 2, 16, 43, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 18, 21, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 361,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 53, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 10, 41, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 362,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 5, 27, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 11, 32, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 363,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 26, 2, 33, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 22, 7, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 364,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 10, 17, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 6, 33, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 365,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 26, 22, 5, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 1, 16, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 366,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 21, 6, 9, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 4, 42, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 367,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 7, 33, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 20, 9, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 368,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 36, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 23, 12, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 369,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 9, 43, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 20, 38, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 370,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 19, 52, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 31, 6, 12, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 371,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 2, 32, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 14, 17, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 372,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 20, 42, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 13, 18, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 373,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 17, 31, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 8, 11, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 374,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 14, 50, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 29, 6, 38, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 375,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 15, 39, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 12, 3, 50, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 376,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 1, 33, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 9, 34, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 377,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 18, 54, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 23, 2, 40, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 378,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 3, 6, 19, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 8, 37, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 379,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 6, 14, 56, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 8, 23, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 380,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 18, 6, 32, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 16, 15, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 381,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 2, 9, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 4, 33, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 382,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 31, 12, 8, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 26, 2, 46, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 383,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 51, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 2, 15, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 384,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 21, 19, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 10, 35, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 385,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 27, 15, 59, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 1, 37, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 386,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 4, 23, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 11, 4, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 387,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 18, 41, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 15, 55, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 388,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 11, 14, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 8, 15, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 389,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 7, 8, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 19, 32, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 390,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 13, 1, 44, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 14, 11, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 391,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 2, 12, 16, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 22, 37, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 392,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 4, 8, 15, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 2, 25, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 393,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 8, 51, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 2, 44, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 394,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 15, 42, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 0, 50, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 395,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 15, 50, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 17, 33, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 396,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 14, 18, 32, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 19, 28, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 397,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 6, 0, 12, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 21, 0, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 398,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 10, 9, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 5, 21, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 399,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 19, 33, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 18, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 400,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 14, 5, 17, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 20, 40, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 401,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 18, 23, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 16, 38, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 402,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 26, 12, 21, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 11, 58, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 403,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 12, 4, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 8, 56, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 404,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 16, 51, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 12, 19, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 405,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 20, 22, 35, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 13, 21, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 406,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 25, 13, 49, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 11, 0, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 407,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 4, 12, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 18, 4, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 408,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 25, 21, 54, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 8, 31, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 409,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 10, 4, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 20, 47, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 410,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 10, 50, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 23, 34, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 411,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 17, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 13, 34, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 412,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 53, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 8, 12, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 413,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 10, 15, 22, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 22, 21, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 414,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 4, 1, 52, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 9, 49, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 415,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 15, 57, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 12, 10, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 416,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 19, 59, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 4, 38, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 417,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 20, 39, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 18, 10, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 418,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 13, 51, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 0, 34, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 419,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 12, 7, 4, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 1, 16, 23, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 420,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 18, 8, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 23, 1, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 421,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 20, 51, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 4, 27, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 422,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 9, 5, 56, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 16, 18, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 423,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 12, 21, 6, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 21, 31, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 424,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 21, 47, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 19, 48, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 425,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 21, 48, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 10, 4, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 426,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 1, 16, 32, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 3, 32, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 427,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 15, 2, 11, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 2, 23, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 428,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 12, 14, 45, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 11, 44, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 429,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 20, 14, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 10, 43, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 430,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 7, 10, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 14, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 431,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 10, 3, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 3, 34, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 432,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 7, 51, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 7, 59, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 433,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 13, 12, 29, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 17, 2, 6, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 434,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 13, 1, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 4, 23, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 435,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 13, 27, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 10, 47, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 436,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 14, 14, 44, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 14, 40, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 437,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 9, 41, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 6, 26, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 438,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 17, 12, 49, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 13, 4, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 439,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 8, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 3, 18, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 440,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 10, 36, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 22, 38, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 441,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 14, 6, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 9, 11, 22, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 442,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 13, 12, 35, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 2, 17, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 443,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 7, 33, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 1, 38, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 444,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 9, 15, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 17, 47, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 445,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 12, 1, 51, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 19, 19, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 446,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 16, 48, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 9, 16, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 447,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 5, 23, 46, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 19, 49, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 448,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 17, 10, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 13, 58, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 449,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 14, 38, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 19, 59, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 450,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 10, 22, 29, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 12, 22, 13, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 451,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 22, 1, 17, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 18, 17, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 452,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 21, 49, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 21, 23, 48, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 453,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 16, 4, 53, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 6, 30, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 454,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 16, 50, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 2, 11, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 455,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 11, 1, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 3, 6, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 456,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 28, 8, 25, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 3, 8, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 457,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 0, 18, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 18, 55, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 458,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 2, 11, 25, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 10, 46, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 459,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 16, 18, 47, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 3, 34, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 460,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 3, 19, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 5, 7, 29, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 461,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 3, 3, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 18, 3, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 462,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 15, 20, 53, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 16, 17, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 463,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 28, 21, 33, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 0, 1, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 464,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 31, 9, 45, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 11, 45, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 465,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 25, 21, 29, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 4, 45, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 466,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 9, 2, 7, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 4, 8, 21, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 467,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 23, 54, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 10, 59, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 468,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 10, 51, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 15, 22, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 469,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 13, 3, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 0, 55, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 470,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 6, 18, 25, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 2, 46, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 471,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 8, 59, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 18, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 472,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 30, 4, 3, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 1, 33, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 473,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 18, 52, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 0, 28, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 474,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 22, 8, 24, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 4, 14, 47, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 475,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 1, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 23, 13, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 476,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 21, 57, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 9, 33, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 477,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 18, 8, 3, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 20, 55, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 478,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 12, 53, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 17, 26, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 479,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 28, 10, 8, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 19, 48, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 480,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 12, 14, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 0, 41, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 481,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 6, 32, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 12, 34, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 482,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 4, 7, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 5, 36, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 483,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 2, 16, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 21, 37, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 484,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 21, 16, 29, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 23, 50, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 485,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 30, 7, 15, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 12, 2, 39, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 486,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 7, 17, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 13, 32, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 487,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 5, 38, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 15, 16, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 488,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 14, 22, 0, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 4, 48, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 489,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 14, 24, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 5, 39, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 490,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 21, 8, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 10, 17, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 491,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 8, 14, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 492,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 21, 43, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 21, 14, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 493,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 15, 41, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 7, 4, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 494,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 10, 11, 50, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 16, 25, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 495,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 21, 17, 24, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 16, 24, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 496,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 2, 29, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 10, 39, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 497,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 13, 12, 35, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 23, 45, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 498,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 27, 6, 32, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 11, 24, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 499,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 11, 7, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 3, 10, 21, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 500,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 11, 19, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 25, 23, 33, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 501,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 5, 17, 9, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 3, 20, 19, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 502,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 7, 56, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 13, 19, 31, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 503,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 13, 19, 7, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 11, 10, 9, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 504,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 13, 6, 50, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 9, 6, 8, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 505,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 21, 39, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 12, 4, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 506,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 8, 52, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 17, 15, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 507,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 9, 19, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 22, 58, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 508,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 18, 26, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 7, 31, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 509,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 2, 21, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 25, 13, 44, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 510,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 6, 20, 44, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 6, 24, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 511,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 24, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 23, 44, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 512,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 6, 44, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 10, 20, 42, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 513,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 28, 7, 45, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 18, 17, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 514,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 29, 8, 3, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 5, 58, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 515,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 5, 17, 46, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 2, 55, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 516,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 30, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 2, 7, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 517,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 11, 9, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 20, 17, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 518,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 11, 10, 40, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 21, 5, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 519,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 16, 34, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 6, 4, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 520,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 17, 40, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 19, 52, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 521,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 11, 7, 18, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 10, 4, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 522,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 4, 0, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 0, 44, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 523,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 12, 37, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 20, 5, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 524,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 14, 18, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 23, 36, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 525,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 16, 8, 17, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 18, 22, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 526,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 19, 46, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 4, 5, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 527,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 0, 51, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 15, 46, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 528,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 26, 16, 10, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 17, 7, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 529,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 28, 18, 29, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 20, 6, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 530,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 29, 6, 57, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 21, 28, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 531,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 17, 7, 10, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 13, 9, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 532,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 17, 5, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 15, 14, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 533,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 15, 34, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 21, 1, 13, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 534,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 16, 25, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 23, 12, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 535,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 4, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 4, 31, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 536,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 1, 15, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 19, 15, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 537,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 24, 11, 44, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 16, 58, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 538,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 24, 22, 36, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 20, 34, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 539,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 1, 7, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 18, 17, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 540,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 30, 17, 29, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 23, 25, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 541,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 23, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 0, 46, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 542,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 19, 24, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 14, 18, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 543,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 22, 3, 6, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 9, 11, 6, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 544,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 18, 40, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 9, 18, 16, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 545,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 9, 11, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 27, 14, 47, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 546,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 34, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 20, 41, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 547,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 13, 38, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 19, 48, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 548,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 8, 33, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 10, 21, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 549,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 16, 20, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 4, 59, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 550,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 9, 27, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 7, 24, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 551,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 9, 52, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 6, 24, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 552,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 10, 35, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 1, 51, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 553,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 11, 15, 22, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 21, 37, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 554,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 21, 15, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 17, 11, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 555,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 3, 42, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 13, 45, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 556,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 18, 3, 23, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 7, 40, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 557,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 21, 5, 54, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 20, 49, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 558,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 23, 59, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 2, 11, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 559,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 24, 22, 5, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 2, 55, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 560,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 21, 54, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 0, 36, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 561,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 17, 18, 51, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 13, 6, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 562,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 5, 6, 42, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 22, 52, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 563,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 9, 16, 52, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 22, 29, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 564,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 0, 33, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 29, 4, 39, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 565,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 16, 55, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 15, 48, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 566,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 21, 20, 32, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 6, 22, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 567,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 17, 29, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 8, 22, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 568,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 21, 33, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 5, 55, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 569,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 8, 6, 24, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 19, 12, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 570,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 18, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 24, 1, 53, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 571,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 17, 23, 19, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 4, 33, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 572,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 28, 12, 53, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 13, 11, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 573,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 18, 10, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 17, 54, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 574,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 12, 43, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 13, 16, 34, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 575,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 11, 47, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 18, 5, 33, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 576,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 43, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 21, 39, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 577,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 18, 14, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 10, 8, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 578,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 24, 12, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 23, 8, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 579,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 14, 12, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 21, 44, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 580,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 13, 39, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 14, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 581,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 20, 19, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 7, 38, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 582,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 0, 44, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 19, 3, 21, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 583,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 20, 44, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 9, 1, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 584,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 13, 24, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 1, 58, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 585,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 19, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 13, 32, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 586,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 17, 23, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 12, 20, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 587,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 0, 45, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 15, 44, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 588,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 16, 5, 0, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 17, 22, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 589,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 21, 19, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 7, 18, 57, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 590,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 7, 4, 0, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 11, 0, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 591,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 24, 19, 22, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 14, 26, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 592,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 20, 31, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 4, 36, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 593,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 8, 33, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 12, 20, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 594,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 11, 9, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 19, 13, 30, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 595,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 9, 38, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 20, 13, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 596,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 4, 2, 1, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 17, 0, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 597,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 0, 13, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 14, 15, 46, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 598,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 17, 1, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 2, 32, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 599,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 26, 9, 58, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 11, 48, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 600,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 4, 8, 26, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 22, 45, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 601,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 24, 9, 49, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 3, 3, 40, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 602,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 27, 21, 48, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 5, 31, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 603,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 0, 16, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 21, 35, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 604,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 17, 49, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 16, 3, 54, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 605,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 6, 11, 34, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 16, 6, 29, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 606,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 22, 10, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 13, 54, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 607,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 14, 2, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 23, 7, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 608,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 11, 21, 10, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 8, 12, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 609,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 8, 4, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 9, 4, 38, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 610,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 36, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 1, 18, 24, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 611,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 10, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 5, 32, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 612,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 21, 3, 48, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 6, 7, 20, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 613,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 45, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 0, 46, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 614,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 3, 5, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 2, 38, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 615,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 10, 2, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 21, 2, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 616,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 14, 0, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 14, 48, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 617,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 14, 11, 3, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 6, 28, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 618,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 11, 11, 46, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 23, 1, 12, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 619,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 28, 9, 45, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 11, 27, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 620,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 5, 6, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 14, 38, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 621,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 4, 18, 13, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 18, 39, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 622,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 22, 27, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 15, 12, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 623,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 17, 17, 48, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 17, 24, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 624,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 16, 7, 36, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 5, 26, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 625,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 26, 22, 5, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 7, 21, 39, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 626,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 8, 41, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 20, 44, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 627,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 23, 34, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 4, 34, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 628,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 10, 17, 31, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 16, 29, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 629,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 13, 21, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 23, 59, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 630,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 22, 10, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 18, 26, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 631,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 23, 19, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 6, 51, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 632,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 1, 24, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 21, 12, 31, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 633,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 17, 38, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 29, 14, 28, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 634,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 25, 16, 18, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 12, 3, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 635,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 17, 17, 52, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 22, 1, 7, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 636,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 26, 0, 49, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 10, 56, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 637,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 18, 6, 54, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 21, 14, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 638,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 2, 1, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 4, 16, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 639,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 12, 8, 42, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 16, 12, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 640,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 4, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 19, 18, 28, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 641,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 14, 12, 31, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 17, 31, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 642,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 23, 45, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 3, 18, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 643,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 19, 7, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 1, 52, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 644,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 4, 22, 26, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 4, 58, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 645,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 6, 50, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 19, 14, 58, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 646,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 5, 30, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 11, 52, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 647,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 21, 4, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 23, 19, 52, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 648,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 4, 39, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 6, 2, 36, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 649,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 18, 13, 19, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 19, 6, 35, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 650,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 19, 3, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 20, 8, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 651,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 14, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 3, 28, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 652,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 3, 7, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 18, 12, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 653,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 10, 13, 42, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 21, 38, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 654,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 0, 39, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 12, 9, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 655,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 24, 19, 0, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 22, 38, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 656,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 10, 9, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 6, 8, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 657,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 0, 53, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 11, 36, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 658,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 4, 1, 18, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 13, 47, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 659,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 11, 4, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 8, 35, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 660,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 3, 19, 0, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 9, 7, 16, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 661,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 15, 42, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 21, 19, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 662,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 11, 9, 31, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 7, 5, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 663,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 4, 26, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 12, 48, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 664,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 9, 15, 56, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 15, 0, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 665,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 29, 4, 22, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 1, 9, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 666,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 14, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 13, 16, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 667,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 1, 5, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 2, 30, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 668,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 1, 16, 1, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 28, 10, 44, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 669,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 3, 11, 17, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 20, 11, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 670,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 11, 15, 8, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 2, 40, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 671,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 14, 4, 41, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 10, 10, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 672,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 3, 13, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 23, 33, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 673,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 10, 34, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 12, 18, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 674,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 20, 9, 34, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 11, 44, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 675,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 8, 1, 21, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 10, 24, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 676,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 22, 5, 50, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 5, 15, 52, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 677,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 7, 26, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 22, 15, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 678,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 8, 15, 15, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 17, 16, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 679,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 5, 14, 23, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 11, 30, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 680,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 10, 19, 41, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 14, 30, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 681,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 7, 6, 46, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 29, 1, 9, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 682,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 4, 20, 31, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 10, 23, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 683,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 19, 41, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 11, 58, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 684,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 19, 10, 54, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 20, 48, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 685,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 5, 1, 55, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 0, 9, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 686,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 19, 23, 30, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 18, 19, 21, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 687,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 23, 18, 44, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 17, 31, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 688,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 19, 20, 56, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 10, 8, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 689,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 18, 1, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 11, 20, 18, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 690,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 26, 5, 53, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 12, 5, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 691,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 12, 21, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 4, 12, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 692,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 2, 3, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 16, 17, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 693,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 11, 9, 26, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 15, 17, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 694,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 11, 5, 43, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 21, 22, 26, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 695,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 9, 43, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 13, 4, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 696,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 4, 12, 50, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 10, 19, 27, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 697,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 31, 1, 9, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 4, 3, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 698,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 20, 5, 20, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 21, 31, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 699,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 0, 9, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 19, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 700,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 1, 1, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 24, 7, 37, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 701,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 24, 15, 27, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 3, 35, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 702,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 1, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 8, 15, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 703,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 13, 16, 20, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 29, 8, 8, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 704,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 19, 57, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 20, 33, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 705,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 31, 16, 36, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 22, 18, 14, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 706,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 21, 45, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 20, 18, 2, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 707,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 2, 15, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 16, 59, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 708,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 3, 46, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 13, 30, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 709,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 7, 14, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 1, 6, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 710,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 13, 55, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 9, 38, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 711,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 23, 10, 57, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 28, 5, 19, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 712,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 4, 9, 41, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 9, 29, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 713,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 18, 13, 10, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 20, 12, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 714,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 9, 18, 20, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 20, 7, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 715,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 13, 12, 58, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 8, 36, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 716,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 28, 12, 39, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 2, 21, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 717,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 2, 24, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 14, 9, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 718,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 25, 12, 38, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 26, 16, 26, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 719,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 15, 59, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 30, 9, 11, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 720,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 29, 13, 51, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 16, 23, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 721,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 17, 10, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 23, 6, 49, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 722,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 20, 28, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 723,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 5, 54, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 11, 2, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 724,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 21, 23, 34, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 19, 38, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 725,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 10, 22, 48, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 17, 52, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 726,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 29, 3, 50, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 17, 6, 46, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 727,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 15, 15, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 3, 45, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 728,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 19, 19, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 19, 44, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 729,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 8, 12, 6, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 29, 11, 43, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 730,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 11, 12, 13, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 19, 27, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 731,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 21, 18, 5, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 12, 33, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 732,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 1, 13, 30, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 0, 12, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 733,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 26, 2, 9, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 5, 58, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 734,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 19, 53, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 4, 8, 53, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 735,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 29, 19, 37, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 24, 22, 16, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 736,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 3, 3, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 20, 24, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 737,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 0, 22, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 16, 7, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 738,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 21, 47, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 17, 16, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 739,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 25, 17, 23, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 11, 3, 14, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 740,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 25, 19, 15, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 2, 0, 59, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 741,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 21, 1, 59, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 22, 23, 34, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 742,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 19, 0, 30, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 18, 44, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 743,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 4, 56, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 21, 16, 21, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 744,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 21, 6, 16, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 12, 59, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 745,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 30, 8, 35, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 4, 56, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 746,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 11, 1, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 17, 55, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 747,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 48, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 1, 19, 43, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 748,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 5, 15, 9, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 24, 2, 44, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 749,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 6, 3, 38, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 17, 57, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 750,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 14, 14, 3, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 14, 22, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 751,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 8, 11, 25, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 9, 17, 26, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 752,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 8, 6, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 22, 29, 20, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 753,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 16, 14, 32, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 10, 18, 24, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 754,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 24, 11, 18, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 3, 13, 46, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 755,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 4, 1, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 13, 6, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 756,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 19, 12, 31, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 26, 4, 35, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 757,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 12, 57, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 23, 17, 8, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 758,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 5, 27, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 19, 59, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 759,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 10, 36, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 11, 5, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 760,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 14, 1, 4, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 13, 13, 10, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 761,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 10, 19, 9, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 28, 5, 45, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 762,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 18, 54, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 20, 17, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 763,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 6, 16, 47, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 12, 51, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 764,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 14, 17, 2, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 20, 32, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 765,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 13, 15, 1, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 10, 54, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 766,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 17, 38, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 29, 23, 19, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 767,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 22, 0, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 17, 25, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 768,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 28, 9, 29, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 23, 33, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 769,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 14, 27, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 1, 27, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 770,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 18, 31, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 22, 55, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 771,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 10, 21, 34, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 25, 2, 53, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 772,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 11, 23, 15, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 28, 14, 43, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 773,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 8, 5, 39, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 27, 1, 52, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 774,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 12, 2, 36, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 2, 19, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 775,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 22, 14, 3, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 14, 12, 9, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 776,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 10, 48, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 10, 13, 53, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 777,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 22, 9, 8, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 21, 5, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 778,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 3, 20, 59, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 10, 35, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 779,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 19, 0, 30, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 29, 13, 14, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 780,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 2, 16, 16, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 5, 46, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 781,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 7, 1, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 16, 15, 24, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 782,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 5, 16, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 14, 19, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 783,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 6, 0, 28, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 6, 21, 0, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 784,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 7, 10, 41, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 3, 5, 27, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 785,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 25, 8, 19, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 26, 17, 29, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 786,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 5, 16, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 11, 47, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 787,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 1, 11, 51, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 13, 22, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 788,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 16, 13, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 6, 47, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 789,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 10, 22, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 16, 48, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 790,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 31, 0, 39, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 22, 52, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 791,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 13, 21, 1, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 4, 14, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 792,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 26, 12, 19, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 13, 14, 25, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 793,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 2, 11, 20, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 14, 23, 36, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 794,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 19, 16, 42, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 0, 54, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 795,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 4, 15, 1, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 12, 14, 30, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 796,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 7, 4, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 7, 8, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 797,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 7, 4, 17, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 20, 52, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 798,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 19, 8, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 15, 20, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 799,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 11, 0, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 1, 37, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 800,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 7, 19, 42, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 17, 15, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 801,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 19, 47, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 0, 21, 34, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 802,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 24, 1, 32, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 19, 8, 2, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 803,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 3, 51, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 21, 26, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 804,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 8, 49, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 5, 37, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 805,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 21, 40, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 3, 44, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 806,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 13, 17, 54, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 18, 16, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 807,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 10, 1, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 15, 13, 28, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 808,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 6, 15, 31, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 16, 50, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 809,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 12, 9, 56, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 2, 12, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 810,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 14, 21, 2, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 15, 39, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 811,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 26, 22, 32, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 4, 0, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 812,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 1, 8, 20, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 21, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 813,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 30, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 9, 13, 55, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 814,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 8, 8, 58, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 13, 37, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 815,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 8, 3, 56, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 21, 38, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 816,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 12, 2, 59, 47, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 15, 12, 18, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 817,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 15, 8, 27, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 15, 0, 24, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 818,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 23, 23, 29, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 0, 7, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 819,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 10, 7, 50, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 18, 11, 48, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 820,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 28, 11, 4, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 3, 20, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 821,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 2, 19, 25, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 13, 52, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 822,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 8, 5, 34, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 27, 5, 12, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 823,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 15, 23, 20, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 0, 37, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 824,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 0, 5, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 14, 28, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 825,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 26, 4, 1, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 0, 36, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 826,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 3, 17, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 14, 6, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 827,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 1, 21, 8, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 10, 32, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 828,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 26, 14, 49, 31, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 18, 20, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 829,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 14, 38, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 20, 45, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 830,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 28, 14, 36, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 18, 0, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 831,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 18, 11, 39, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 20, 0, 4, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 832,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 58, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 2, 57, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 833,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 11, 11, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 1, 42, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 834,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 7, 1, 42, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 19, 30, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 835,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 8, 47, 55, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 3, 14, 10, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 836,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 12, 7, 37, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 27, 6, 2, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 837,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 12, 3, 23, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 2, 22, 20, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 838,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 3, 12, 26, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 14, 35, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 839,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 12, 34, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 11, 44, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 840,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 41, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 6, 19, 28, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 841,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 8, 16, 50, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 1, 4, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 842,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 27, 12, 44, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 13, 3, 48, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 843,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 6, 21, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 23, 24, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 844,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 22, 6, 2, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 10, 1, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 845,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 22, 3, 20, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 28, 1, 4, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 846,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 20, 3, 29, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 27, 9, 24, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 847,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 13, 12, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 21, 26, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 848,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 6, 2, 10, 18, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 23, 8, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 849,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 28, 22, 4, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 30, 19, 39, 24, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 850,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 3, 23, 42, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 3, 38, 36, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 851,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 1, 19, 28, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 11, 15, 8, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 852,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 23, 19, 35, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 12, 5, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 853,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 44, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 9, 45, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 854,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 4, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 18, 24, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 855,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 28, 1, 5, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 6, 18, 3, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 856,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 2, 15, 22, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 25, 5, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 857,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 24, 8, 57, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 17, 20, 45, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 858,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 12, 36, 50, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 15, 7, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 859,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 10, 10, 10, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 1, 1, 10, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 860,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 23, 13, 43, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 11, 16, 20, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 861,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 19, 23, 1, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 27, 0, 28, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 862,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 5, 1, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 8, 8, 58, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 863,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 11, 4, 57, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 25, 7, 45, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 864,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 10, 8, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 12, 23, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 865,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 0, 33, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 20, 48, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 866,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 16, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 4, 1, 0, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 867,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 23, 12, 10, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 6, 15, 18, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 868,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 18, 9, 32, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 11, 56, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 869,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 28, 2, 54, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 23, 20, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 870,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 11, 21, 37, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 2, 16, 0, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 871,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 31, 19, 20, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 17, 15, 25, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 872,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 13, 17, 51, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 9, 10, 4, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 873,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 11, 5, 42, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 5, 13, 58, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 874,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 6, 16, 0, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 20, 19, 14, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 875,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 14, 9, 47, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 25, 21, 43, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 876,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 28, 19, 25, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 21, 1, 24, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 877,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 15, 7, 5, 38, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 4, 13, 33, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 878,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 13, 23, 23, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 3, 9, 11, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 879,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 6, 43, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 15, 39, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 880,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 13, 10, 13, 54, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 31, 12, 29, 43, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 881,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 17, 45, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 8, 29, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 882,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 7, 10, 58, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 9, 20, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 883,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 5, 17, 6, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 4, 5, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 884,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 2, 14, 46, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 10, 0, 18, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 885,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 15, 21, 4, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 1, 25, 27, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 886,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 5, 8, 4, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 16, 51, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 887,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 8, 9, 6, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 11, 10, 17, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 888,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 27, 15, 41, 27, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 17, 19, 58, 32, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 889,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 16, 8, 17, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 8, 43, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 890,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 3, 5, 8, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 22, 17, 33, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 891,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 0, 39, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 23, 57, 33, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 892,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 23, 15, 56, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 24, 15, 13, 23, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 893,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 19, 4, 30, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 6, 10, 38, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 894,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 30, 18, 14, 22, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 1, 32, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 895,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 27, 5, 23, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 2, 24, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 896,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 8, 5, 43, 11, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 19, 26, 2, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 897,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 14, 4, 38, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 2, 11, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 898,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 23, 8, 9, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 6, 43, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 899,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 21, 16, 34, 48, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 12, 33, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 900,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 23, 14, 47, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 22, 0, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 901,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 6, 2, 16, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 31, 10, 16, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 902,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 17, 23, 9, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 15, 19, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 903,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 30, 23, 43, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 1, 6, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 904,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 21, 6, 48, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 18, 15, 37, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 905,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 24, 18, 33, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 4, 21, 27, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 906,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 26, 12, 33, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 20, 31, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 907,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 21, 4, 19, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 6, 42, 4, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 908,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 17, 13, 34, 34, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 26, 13, 25, 15, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 909,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 7, 13, 13, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 4, 23, 38, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 910,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 22, 5, 4, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 19, 28, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 911,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 8, 22, 30, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 11, 24, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 912,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 12, 14, 4, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 31, 4, 1, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 913,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 6, 13, 25, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 8, 54, 53, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 914,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 5, 4, 16, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 9, 1, 29, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 915,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 3, 22, 13, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 18, 47, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 916,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 9, 17, 30, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 9, 18, 44, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 917,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 21, 6, 19, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 26, 21, 28, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 918,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 12, 1, 2, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 16, 41, 28, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 919,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 18, 18, 45, 51, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 9, 5, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 920,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 14, 5, 55, 24, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 22, 18, 35, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 921,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 11, 7, 45, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 12, 43, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 922,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 15, 10, 13, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 15, 9, 34, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 923,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 11, 13, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 17, 45, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 924,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 10, 9, 40, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 7, 5, 31, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 925,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 12, 21, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 21, 56, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 926,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 16, 18, 46, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 4, 14, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 927,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 18, 5, 50, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 21, 16, 36, 11, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 928,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 7, 14, 13, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 28, 20, 12, 17, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 929,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 6, 47, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 26, 6, 31, 25, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 930,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 11, 9, 39, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 18, 8, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 931,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 22, 9, 52, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 21, 57, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 932,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 3, 20, 6, 58, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 5, 5, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 933,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 23, 6, 5, 21, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 9, 11, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 934,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 5, 1, 49, 10, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 0, 37, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 935,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 2, 15, 1, 30, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 11, 56, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 936,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 8, 21, 24, 49, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 28, 11, 38, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 937,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 30, 21, 42, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 30, 1, 37, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 938,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 13, 20, 1, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 8, 47, 31, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 939,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 30, 20, 3, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 7, 13, 30, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 940,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 28, 6, 47, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 16, 47, 57, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 941,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 4, 20, 37, 45, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 18, 46, 29, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 942,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 2, 32, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 18, 20, 54, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 943,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 7, 32, 3, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 23, 18, 50, 50, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 944,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 24, 14, 25, 14, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 10, 15, 15, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 945,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 9, 21, 16, 52, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 11, 2, 39, 12, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 946,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 22, 20, 0, 35, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 14, 15, 1, 58, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 947,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 8, 20, 11, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 8, 15, 49, 30, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 948,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 13, 29, 46, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 16, 18, 39, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 949,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 23, 0, 33, 5, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 0, 19, 10, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 950,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 15, 13, 58, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 10, 2, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 951,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 20, 21, 46, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 27, 7, 8, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 952,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 5, 10, 42, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 8, 23, 43, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 953,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 2, 3, 57, 12, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 18, 3, 27, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 954,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 12, 16, 18, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 12, 48, 46, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 955,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 21, 19, 15, 53, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 14, 1, 10, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 956,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 20, 17, 0, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 20, 7, 16, 5, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 957,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 21, 7, 5, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 17, 12, 59, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 958,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 16, 15, 34, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 6, 55, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 959,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 5, 15, 22, 47, 2, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 17, 11, 1, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 960,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 25, 15, 17, 15, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 22, 0, 56, 14, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 961,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 25, 23, 58, 29, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 10, 12, 10, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 962,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 16, 15, 42, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 22, 39, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 963,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 13, 2, 33, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 2, 21, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 964,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 3, 9, 25, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 13, 16, 46, 8, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 965,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 1, 19, 47, 16, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 10, 41, 56, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 966,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 9, 11, 3, 9, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 22, 45, 18, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 967,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 3, 0, 12, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 3, 29, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 968,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 20, 17, 43, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 4, 4, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 969,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 13, 8, 7, 56, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 27, 12, 40, 55, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 970,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 4, 13, 30, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 9, 54, 49, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 971,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 8, 4, 30, 57, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 5, 5, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 972,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 20, 10, 18, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 16, 45, 38, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 973,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 16, 5, 27, 19, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 24, 17, 23, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 974,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 27, 23, 11, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 26, 12, 8, 21, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 975,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 58, 44, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 19, 25, 13, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 976,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 9, 9, 41, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 16, 52, 48, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 977,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 13, 22, 0, 1, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 8, 3, 16, 40, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 978,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 15, 1, 10, 20, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 3, 2, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 979,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 2, 6, 28, 6, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 12, 5, 52, 45, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 980,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 25, 16, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 18, 19, 52, 19, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 981,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 9, 20, 46, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 11, 17, 28, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 982,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 25, 1, 9, 37, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 13, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 983,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 1, 19, 16, 4, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 30, 17, 53, 35, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 984,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 6, 18, 6, 23, 28, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 16, 22, 40, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 985,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 4, 9, 3, 10, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 29, 5, 13, 47, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 986,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 3, 12, 35, 17, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 19, 36, 51, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 987,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 11, 36, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 27, 10, 31, 7, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 988,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 12, 5, 8, 11, 40, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 26, 6, 9, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 989,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 7, 10, 22, 25, 8, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 13, 19, 1, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 990,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 7, 21, 48, 59, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 20, 38, 16, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 991,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 2, 26, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 7, 4, 56, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 992,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 2, 7, 48, 43, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 5, 20, 57, 41, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 993,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 2, 6, 16, 3, 4, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 16, 22, 31, 9, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 994,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 8, 14, 20, 15, 33, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 16, 5, 22, 26, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 995,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 10, 22, 10, 32, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 5, 23, 54, 42, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 996,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 25, 14, 31, 7, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 11, 27, 6, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 997,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 3, 15, 0, 1, 41, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 5, 24, 37, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 998,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 11, 13, 11, 45, 13, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 7, 46, 3, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 999,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 9, 6, 13, 55, 39, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 2, 3, 54, 54, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "TimeRegistrationId",
                keyValue: 1000,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2024, 10, 25, 16, 39, 23, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 22, 18, 53, 47, 0, DateTimeKind.Unspecified) });
        }
    }
}
