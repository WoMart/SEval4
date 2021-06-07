using Microsoft.EntityFrameworkCore.Migrations;

namespace SEval4.Migrations
{
    public partial class ResponseValueToId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ResponseValue",
                table: "SurveyAnswers",
                newName: "ResponseId");

            migrationBuilder.RenameColumn(
                name: "ResponseValue",
                table: "EvaluationAnswers",
                newName: "ResponseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ResponseId",
                table: "SurveyAnswers",
                newName: "ResponseValue");

            migrationBuilder.RenameColumn(
                name: "ResponseId",
                table: "EvaluationAnswers",
                newName: "ResponseValue");
        }
    }
}
