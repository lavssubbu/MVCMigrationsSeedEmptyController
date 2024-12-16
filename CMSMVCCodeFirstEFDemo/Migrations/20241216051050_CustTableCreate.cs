using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMSMVCCodeFirstEFDemo.Migrations
{
    /// <inheritdoc />
    public partial class CustTableCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    custId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    custName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    custLoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateofbirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.custId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");
        }
    }
}
