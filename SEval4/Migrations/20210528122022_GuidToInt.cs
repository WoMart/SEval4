using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SEval4.Migrations
{
    public partial class GuidToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EvaluationScenarios",
                keyColumn: "Id",
                keyValue: new Guid("23fe6169-fdea-430c-bfa3-91f39bf48989"));

            migrationBuilder.DeleteData(
                table: "EvaluationScenarios",
                keyColumn: "Id",
                keyValue: new Guid("e68bd51c-93ba-4077-939f-790e9ba1ebb7"));

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: new Guid("31e6115b-3ab1-4deb-be1a-8c3f6889ade5"));

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: new Guid("c0ef8cd8-3d33-4031-a953-d5f665d6f973"));

            migrationBuilder.DeleteData(
                table: "StudyGroups",
                keyColumn: "Id",
                keyValue: new Guid("19ee9aac-9925-492f-80fc-19eef695d143"));

            migrationBuilder.DeleteData(
                table: "StudyGroups",
                keyColumn: "Id",
                keyValue: new Guid("282e6279-86a6-4d5e-8e96-9d6545786151"));

            migrationBuilder.DropColumn(
                name: "ScenarioId",
                table: "Scenarios");

            migrationBuilder.DropColumn(
                name: "ScenarioId",
                table: "EvaluationScenarios");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "SurveyAnswers",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Scenarios",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "EvaluationScenarios",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "EvaluationScenarios",
                columns: new[] { "Id", "Context", "Feedback" },
                values: new object[,]
                {
                    { 3, "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is very sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what user-name you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?", "Placeholder feedback 1" },
                    { 4, "You are a Computer Science Honours student at UCT, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have a big network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in Cape Town. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position as of yet post studies? I’d be keen to have a chat with you to find out what It is that really interests you so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?", "Placeholder feedback 2" }
                });

            migrationBuilder.InsertData(
                table: "Scenarios",
                columns: new[] { "Id", "Context" },
                values: new object[,]
                {
                    { 1, "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is very sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what user-name you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?" },
                    { 2, "You are a Computer Science Honours student at UCT, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have a big network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in Cape Town. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position as of yet post studies? I’d be keen to have a chat with you to find out what It is that really interests you so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?" }
                });

            migrationBuilder.InsertData(
                table: "StudyGroups",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("87cea1fb-8670-4866-bd89-cb4f6cbf0251"), "SEADM" },
                    { new Guid("9a2227d6-2b4e-4234-b32b-acfc85c301cd"), "Feedback" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Responses_ScenarioId",
                table: "Responses",
                column: "ScenarioId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationResponses_ScenarioId",
                table: "EvaluationResponses",
                column: "ScenarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_EvaluationResponses_Scenarios_ScenarioId",
                table: "EvaluationResponses",
                column: "ScenarioId",
                principalTable: "Scenarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_Scenarios_ScenarioId",
                table: "Responses",
                column: "ScenarioId",
                principalTable: "Scenarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EvaluationResponses_Scenarios_ScenarioId",
                table: "EvaluationResponses");

            migrationBuilder.DropForeignKey(
                name: "FK_Responses_Scenarios_ScenarioId",
                table: "Responses");

            migrationBuilder.DropIndex(
                name: "IX_Responses_ScenarioId",
                table: "Responses");

            migrationBuilder.DropIndex(
                name: "IX_EvaluationResponses_ScenarioId",
                table: "EvaluationResponses");

            migrationBuilder.DeleteData(
                table: "EvaluationScenarios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EvaluationScenarios",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StudyGroups",
                keyColumn: "Id",
                keyValue: new Guid("87cea1fb-8670-4866-bd89-cb4f6cbf0251"));

            migrationBuilder.DeleteData(
                table: "StudyGroups",
                keyColumn: "Id",
                keyValue: new Guid("9a2227d6-2b4e-4234-b32b-acfc85c301cd"));

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "SurveyAnswers",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Scenarios",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ScenarioId",
                table: "Scenarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "EvaluationScenarios",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ScenarioId",
                table: "EvaluationScenarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "EvaluationScenarios",
                columns: new[] { "Id", "Context", "Feedback", "ScenarioId" },
                values: new object[,]
                {
                    { new Guid("23fe6169-fdea-430c-bfa3-91f39bf48989"), "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is very sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what user-name you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?", "Placeholder feedback 1", 3 },
                    { new Guid("e68bd51c-93ba-4077-939f-790e9ba1ebb7"), "You are a Computer Science Honours student at UCT, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have a big network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in Cape Town. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position as of yet post studies? I’d be keen to have a chat with you to find out what It is that really interests you so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?", "Placeholder feedback 2", 4 }
                });

            migrationBuilder.InsertData(
                table: "Scenarios",
                columns: new[] { "Id", "Context", "ScenarioId" },
                values: new object[,]
                {
                    { new Guid("31e6115b-3ab1-4deb-be1a-8c3f6889ade5"), "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is very sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what user-name you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?", 1 },
                    { new Guid("c0ef8cd8-3d33-4031-a953-d5f665d6f973"), "You are a Computer Science Honours student at UCT, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have a big network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in Cape Town. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position as of yet post studies? I’d be keen to have a chat with you to find out what It is that really interests you so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?", 2 }
                });

            migrationBuilder.InsertData(
                table: "StudyGroups",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("19ee9aac-9925-492f-80fc-19eef695d143"), "SEADM" },
                    { new Guid("282e6279-86a6-4d5e-8e96-9d6545786151"), "Feedback" }
                });
        }
    }
}
