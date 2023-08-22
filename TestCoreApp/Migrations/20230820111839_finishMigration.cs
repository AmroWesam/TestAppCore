using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class finishMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "513ac1f5-c406-4378-ab40-46e7ff3df21a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b42d5b1f-de73-4c28-9db9-027aeb2214aa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6e68be52-9320-4012-863d-b2a31866ca80", "ae57fe58-587d-418e-a023-604da1edec00", "User", "user" },
                    { "9702e576-8324-4024-ac07-93af4aa2bb6e", "35027852-e54b-44bd-8872-e8b5c4cc1721", "Admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e68be52-9320-4012-863d-b2a31866ca80");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9702e576-8324-4024-ac07-93af4aa2bb6e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "513ac1f5-c406-4378-ab40-46e7ff3df21a", "7c950c08-f9ce-473e-9342-f9daab2beee3", "Admin", "admin" },
                    { "b42d5b1f-de73-4c28-9db9-027aeb2214aa", "626b8079-6b2d-4872-acbf-f56cf4ebb89f", "User", "user" }
                });
        }
    }
}
