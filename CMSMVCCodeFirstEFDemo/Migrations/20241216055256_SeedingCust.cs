using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CMSMVCCodeFirstEFDemo.Migrations
{
    /// <inheritdoc />
    public partial class SeedingCust : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "custId", "custLoc", "custName", "dateofbirth" },
                values: new object[,]
                {
                    { 1, "Chennai", "Reena", new DateTime(2000, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Pune", "Riyaz", new DateTime(2001, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "custId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "custId",
                keyValue: 2);
        }
    }
}
