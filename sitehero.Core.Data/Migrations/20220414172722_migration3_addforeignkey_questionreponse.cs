using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sitehero.Core.Data.Migrations
{
    public partial class migration3_addforeignkey_questionreponse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Reponse_QuestionId",
                table: "Reponse",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reponse_Question_QuestionId",
                table: "Reponse",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reponse_Question_QuestionId",
                table: "Reponse");

            migrationBuilder.DropIndex(
                name: "IX_Reponse_QuestionId",
                table: "Reponse");
        }
    }
}
