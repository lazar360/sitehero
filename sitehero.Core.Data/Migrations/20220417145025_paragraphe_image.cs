using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sitehero.Core.Data.Migrations
{
    public partial class paragraphe_image : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Paragraphe",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Paragraphe");
        }
    }
}
