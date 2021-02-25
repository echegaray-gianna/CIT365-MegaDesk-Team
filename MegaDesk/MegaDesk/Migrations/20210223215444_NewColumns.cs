using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDesk.Migrations
{
    public partial class NewColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Area",
                table: "DeskQuote",
                type: "float(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<float>(
                name: "Cost",
                table: "DeskQuote",
                type: "float(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "DeskQuote");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "DeskQuote");
        }
    }
}
