using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sitehero.Core.Data.Migrations
{
    public partial class EstInitialParagraphe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EstInitial",
                table: "Paragraphe",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstInitial",
                table: "Paragraphe");
        }
    }
}
