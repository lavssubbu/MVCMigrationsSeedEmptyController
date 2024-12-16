using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMSMVCCodeFirstEFDemo.Migrations
{
    /// <inheritdoc />
    public partial class addcustamountcol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "CustAmount",
                table: "Order",
                type: "decimal(10,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "CustAmount",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustAmount",
                table: "Order");
        }
    }
}
