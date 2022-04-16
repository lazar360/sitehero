using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sitehero.Core.Data.Migrations
{
    public partial class LienParagrapheReponse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParagrapheId",
                table: "Reponse",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParagrapheId",
                table: "Reponse");
        }
    }
}
