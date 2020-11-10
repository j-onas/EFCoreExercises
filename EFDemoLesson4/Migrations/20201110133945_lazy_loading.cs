using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDemoLesson4.Migrations
{
    public partial class lazy_loading : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2020, 11, 10, 14, 39, 44, 534, DateTimeKind.Local).AddTicks(1172));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfPurchase",
                value: new DateTime(2020, 11, 10, 11, 30, 16, 978, DateTimeKind.Local).AddTicks(5764));
        }
    }
}
