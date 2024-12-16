using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMSMVCCodeFirstEFDemo.Migrations
{
    /// <inheritdoc />
    public partial class seedorder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "CustId", "OrderDate", "ProductName" },
                values: new object[] { 1, 2, new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1);
        }
    }
}
