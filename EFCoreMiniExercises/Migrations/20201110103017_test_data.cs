using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreMiniExercises.Migrations
{
    public partial class test_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "BonusPoints", "FirstName", "Gender", "LastName" },
                values: new object[] { 1, 45000, "Björn", 0, "Strömberg" });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "CustomerId", "DateOfPurchase" },
                values: new object[] { 1, 1, new DateTime(2020, 11, 10, 11, 30, 16, 978, DateTimeKind.Local).AddTicks(5764) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
