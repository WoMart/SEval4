using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SEval4.Migrations
{
    public partial class Progression : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BaselineSurveyCompletionTime",
                table: "Participants",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EvaluationCompletionTime",
                table: "Participants",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FeedbackCompletionTime",
                table: "Participants",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ParticipantSurveyCompletionTime",
                table: "Participants",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PostgameSurveyCompletionTime",
                table: "Participants",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BaselineSurveyCompletionTime",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "EvaluationCompletionTime",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "FeedbackCompletionTime",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "ParticipantSurveyCompletionTime",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "PostgameSurveyCompletionTime",
                table: "Participants");
        }
    }
}
