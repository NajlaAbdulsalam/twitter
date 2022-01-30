using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "created_at", "password", "updated_at", "user_name" },
                values: new object[] { 1, new DateTime(2022, 1, 30, 2, 57, 29, 859, DateTimeKind.Local), "132", new DateTime(2022, 1, 30, 2, 57, 29, 860, DateTimeKind.Local), "Mary" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "created_at", "password", "updated_at", "user_name" },
                values: new object[] { 2, new DateTime(2022, 1, 30, 2, 57, 29, 860, DateTimeKind.Local), "456", new DateTime(2022, 1, 30, 2, 57, 29, 860, DateTimeKind.Local), "Harry" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
