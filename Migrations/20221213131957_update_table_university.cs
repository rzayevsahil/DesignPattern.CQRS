using Microsoft.EntityFrameworkCore.Migrations;

namespace DesignPattern.CQRS.PresentationLayer.Migrations
{
    public partial class update_table_university : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Count",
                table: "Universities",
                newName: "Region");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Universities",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Universities");

            migrationBuilder.RenameColumn(
                name: "Region",
                table: "Universities",
                newName: "Count");
        }
    }
}
