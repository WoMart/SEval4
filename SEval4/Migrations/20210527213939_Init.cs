using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SEval4.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgeGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgeGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConfidenceGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfidenceGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationResponses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScenarioId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationResponses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationScenarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScenarioId = table.Column<int>(type: "int", nullable: false),
                    Context = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationScenarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParticipantSurveys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AgeGroup = table.Column<int>(type: "int", nullable: false),
                    EducationGroup = table.Column<int>(type: "int", nullable: false),
                    ProfessionalExperience = table.Column<int>(type: "int", nullable: false),
                    HasFormalTraining = table.Column<int>(type: "int", nullable: false),
                    HasInformalTraining = table.Column<int>(type: "int", nullable: false),
                    PhishingConfidence = table.Column<int>(type: "int", nullable: false),
                    HumanConfidence = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantSurveys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScenarioId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Scenarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScenarioId = table.Column<int>(type: "int", nullable: false),
                    Context = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scenarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudyGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurveyAnswers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScenarioId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyAnswers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YearGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsFinished = table.Column<bool>(type: "bit", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AllocationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StudyGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Participants_StudyGroups_StudyGroupId",
                        column: x => x.StudyGroupId,
                        principalTable: "StudyGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AttemptCounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScenarioId = table.Column<int>(type: "int", nullable: false),
                    Attempts = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttemptCounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttemptCounts_Participants_UserId",
                        column: x => x.UserId,
                        principalTable: "Participants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ScenarioId = table.Column<int>(type: "int", nullable: false),
                    ResponseValue = table.Column<int>(type: "int", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvaluationAnswers_Participants_UserId",
                        column: x => x.UserId,
                        principalTable: "Participants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AgeGroup",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { 1, "18 - 24 years old" },
                    { 2, "25 - 34 years old" },
                    { 3, "35 - 44 years old" },
                    { 4, "45 - 54 years old" },
                    { 5, "55 - 64 years old" },
                    { 6, "65+ years old" }
                });

            migrationBuilder.InsertData(
                table: "ConfidenceGroups",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { 5, "Full confidence" },
                    { 3, "Moderate confidence" },
                    { 4, "High confidence" },
                    { 1, "No confidence" },
                    { 2, "Low confidence" }
                });

            migrationBuilder.InsertData(
                table: "EducationGroups",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { 1, "Primary Education" },
                    { 2, "Secondary Education" },
                    { 3, "Vocational training" },
                    { 4, "Bachelor degree or equivalent" },
                    { 5, "Postgraduate Master" },
                    { 6, "PhD" }
                });

            migrationBuilder.InsertData(
                table: "EvaluationResponses",
                columns: new[] { "Id", "Description", "IsCorrect", "ScenarioId", "Text", "Value" },
                values: new object[,]
                {
                    { 7, "Ignore and block", false, 4, "Ignore the email and remove the recruiter from your LinkedIn.", 3 },
                    { 8, "Use the number to arrange a meeting", true, 4, "Give the recruiter a call on one of the two numbers provided and arrange to meet up with him to discuss how he can help you.", 4 },
                    { 6, "Accept immediately and provide too much data", false, 4, "You have been job hunting for ages and see this as a blessing in disguise. You reply to the email saying that you would appreciate his help and attach a copy of your CV, a copy of your ID and a link to your GitHub account. (Since you know he will most likely request all this information anyway.", 2 },
                    { 5, "Click on the links and decide later", false, 4, "Click on the links provided, and have a look at the company’s online profile as well as reviews left by others. If all seems good, get in contact with the recruiter.", 1 },
                    { 3, "Accept immediately", false, 3, "Instantly provide her with your login details and wish her a merry Christmas.", 3 },
                    { 2, "Refer to colleague", false, 3, "Ask her to contact one of your colleagues since you are on holiday.", 2 },
                    { 1, "Refuse immidately", true, 3, "Refuse to help her entirely and hang up the phone.", 1 },
                    { 4, "Ask more questions and decide later", false, 3, "Ask her a few complementary questions and based on her answers either provide her with your login details or don’t provide her with any information.", 4 }
                });

            migrationBuilder.InsertData(
                table: "EvaluationScenarios",
                columns: new[] { "Id", "Context", "Feedback", "ScenarioId" },
                values: new object[,]
                {
                    { new Guid("23fe6169-fdea-430c-bfa3-91f39bf48989"), "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is very sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what user-name you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?", "Placeholder feedback 1", 3 },
                    { new Guid("e68bd51c-93ba-4077-939f-790e9ba1ebb7"), "You are a Computer Science Honours student at UCT, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have a big network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in Cape Town. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position as of yet post studies? I’d be keen to have a chat with you to find out what It is that really interests you so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?", "Placeholder feedback 2", 4 }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "Description", "ScenarioId", "Text", "Value" },
                values: new object[,]
                {
                    { 5, "Click on the links and decide later", 2, "Click on the links provided, and have a look at the company’s online profile as well as reviews left by others. If all seems good, get in contact with the recruiter.", 1 },
                    { 8, "Use the number to arrange a meeting", 2, "Give the recruiter a call on one of the two numbers provided and arrange to meet up with him to discuss how he can help you.", 4 },
                    { 7, "Ignore and block", 2, "Ignore the email and remove the recruiter from your LinkedIn.", 3 },
                    { 6, "Accept immediately and provide too much data", 2, "You have been job hunting for ages and see this as a blessing in disguise. You reply to the email saying that you would appreciate his help and attach a copy of your CV, a copy of your ID and a link to your GitHub account. (Since you know he will most likely request all this information anyway.", 2 },
                    { 4, "Ask more questions and decide later", 1, "Ask her a few complementary questions and based on her answers either provide her with your login details or don’t provide her with any information.", 4 },
                    { 3, "Accept immediately", 1, "Instantly provide her with your login details and wish her a merry Christmas.", 3 },
                    { 2, "Refer to colleague", 1, "Ask her to contact one of your colleagues since you are on holiday.", 2 },
                    { 1, "Refuse immidately", 1, "Refuse to help her entirely and hang up the phone.", 1 }
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

            migrationBuilder.InsertData(
                table: "YearGroups",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { 2, "2 - 3 years" },
                    { 3, "4 - 5 years" },
                    { 1, "1 year or less" }
                });

            migrationBuilder.InsertData(
                table: "YearGroups",
                columns: new[] { "Id", "Text" },
                values: new object[] { 4, "6 years or more" });

            migrationBuilder.CreateIndex(
                name: "IX_AttemptCounts_UserId",
                table: "AttemptCounts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluationAnswers_UserId",
                table: "EvaluationAnswers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_StudyGroupId",
                table: "Participants",
                column: "StudyGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgeGroup");

            migrationBuilder.DropTable(
                name: "AttemptCounts");

            migrationBuilder.DropTable(
                name: "ConfidenceGroups");

            migrationBuilder.DropTable(
                name: "EducationGroups");

            migrationBuilder.DropTable(
                name: "EvaluationAnswers");

            migrationBuilder.DropTable(
                name: "EvaluationResponses");

            migrationBuilder.DropTable(
                name: "EvaluationScenarios");

            migrationBuilder.DropTable(
                name: "ParticipantSurveys");

            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Scenarios");

            migrationBuilder.DropTable(
                name: "SurveyAnswers");

            migrationBuilder.DropTable(
                name: "YearGroups");

            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "StudyGroups");
        }
    }
}
