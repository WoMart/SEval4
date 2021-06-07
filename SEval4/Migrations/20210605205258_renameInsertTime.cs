using Microsoft.EntityFrameworkCore.Migrations;

namespace SEval4.Migrations
{
    public partial class renameInsertTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InsertTime",
                table: "SurveyAnswers",
                newName: "CreateTime");

            migrationBuilder.RenameColumn(
                name: "InsertTime",
                table: "EvaluationAnswers",
                newName: "CreateTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateTime",
                table: "SurveyAnswers",
                newName: "InsertTime");

            migrationBuilder.RenameColumn(
                name: "CreateTime",
                table: "EvaluationAnswers",
                newName: "InsertTime");
        }
    }
}
