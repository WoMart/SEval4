using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SEval4.Migrations
{
    public partial class Feedback : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConfidenceChange",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfidenceChange", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParticipantFeedback",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudyHelpfulness = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhishingConfidenceChange = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpearPhishingConfidenceChange = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScenarioFeedback = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainingFeedback = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeneralFeedback = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantFeedback", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudyHelpfulness",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyHelpfulness", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ConfidenceChange",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { 1, "Very positively" },
                    { 2, "Somewhat positively" },
                    { 3, "No change at all" },
                    { 4, "Somewhat negatively" },
                    { 5, "Very negatively" }
                });

            migrationBuilder.InsertData(
                table: "StudyHelpfulness",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { 1, "Very helpful" },
                    { 2, "Somewhat helpful" },
                    { 3, "Unsure" },
                    { 4, "A little helpful" },
                    { 5, "Not helpful at all" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConfidenceChange");

            migrationBuilder.DropTable(
                name: "ParticipantFeedback");

            migrationBuilder.DropTable(
                name: "StudyHelpfulness");
        }
    }
}
