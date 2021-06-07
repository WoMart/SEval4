using Microsoft.EntityFrameworkCore.Migrations;

namespace SEval4.Migrations
{
    public partial class RenameHumanConfidence : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HumanConfidence",
                table: "ParticipantSurveys",
                newName: "SpearPhishingConfidence");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SpearPhishingConfidence",
                table: "ParticipantSurveys",
                newName: "HumanConfidence");
        }
    }
}
