using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sitehero.Core.Data.Migrations
{
    public partial class lienParagrapheSuivantReponse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ParagrapheId",
                table: "Reponse",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Reponse_ParagrapheId",
                table: "Reponse",
                column: "ParagrapheId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reponse_Paragraphe_ParagrapheId",
                table: "Reponse",
                column: "ParagrapheId",
                principalTable: "Paragraphe",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reponse_Paragraphe_ParagrapheId",
                table: "Reponse");

            migrationBuilder.DropIndex(
                name: "IX_Reponse_ParagrapheId",
                table: "Reponse");

            migrationBuilder.AlterColumn<int>(
                name: "ParagrapheId",
                table: "Reponse",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
