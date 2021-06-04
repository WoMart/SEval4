using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SEval4.Migrations
{
    public partial class SurveyNameForAnswers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SurveyName",
                table: "SurveyAnswers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: 6,
                column: "Context",
                value: "Whilst walking towards the entrance turnstile at the computer lab, a person whom you have never met or seen before approaches you. This person looks to be in their early 20s and looks like a fellow student. The person tells you that he has forgotten his student card at home and can now not enter through the turnstile to use the computers in the lab. The person asks if you could assist him with entering through the turnstile by allowing him to swipe in using your student card. Your card allows you to both swipe in and enter the computer lab. The person looks incredibly stressed and tells you he has an assignment due in 15 minutes that he needs to get access to a computer to submit. You know that there are policies in place that disallow swiping in other students to labs, however it will not harm you in any way to swipe in a fellow student and you could help him pass the course by helping him get to a computer to submit his assignment on time. Which action do you take?");

            migrationBuilder.UpdateData(
                table: "StudyGroups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Identifier",
                value: new Guid("c43e55f6-cf02-4cc2-bbd6-601b37f0beb1"));

            migrationBuilder.UpdateData(
                table: "StudyGroups",
                keyColumn: "Id",
                keyValue: 2,
                column: "Identifier",
                value: new Guid("7a8d2920-cb1c-4f7b-8513-1dc19a2c9634"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SurveyName",
                table: "SurveyAnswers");

            migrationBuilder.UpdateData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: 6,
                column: "Context",
                value: "Whilst walking towards the entrance turnstile at the computer lab, a person whom you have never met or seen before approaches you. This person is about the same age as you and looks like a fellow student. The person tells you that he has forgotten his student card at home and can now not enter through the turnstile to use the computers in the lab. The person asks if you could assist him with entering through the turnstile by allowing him to swipe in using your student card. Your card allows you to both swipe in and enter the computer lab. The person looks incredibly stressed and tells you he has an assignment due in 15 minutes that he needs to get access to a computer to submit. You know that there are policies in place that disallow swiping in other students to labs, however it will not harm you in any way to swipe in a fellow student and you could help him pass the course by helping him get to a computer to submit his assignment on time. Which action do you take?");

            migrationBuilder.UpdateData(
                table: "StudyGroups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Identifier",
                value: new Guid("38e321c8-43ff-4289-9a0a-553097acf405"));

            migrationBuilder.UpdateData(
                table: "StudyGroups",
                keyColumn: "Id",
                keyValue: 2,
                column: "Identifier",
                value: new Guid("869ae0a0-29ec-4aa5-bfa1-8ec86c56f9e9"));
        }
    }
}
