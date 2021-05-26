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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgeGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnswersBaseline",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScenarioId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswersBaseline", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConfidenceGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfidenceGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationResponses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    ScenarioId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseOrder = table.Column<int>(type: "int", nullable: false)
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    ScenarioId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseOrder = table.Column<int>(type: "int", nullable: false)
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
                name: "YearGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.InsertData(
                table: "AgeGroup",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("492747c1-d057-4ef7-8dbf-880ffe8a1836"), "18 - 24 years old", 1 },
                    { new Guid("0829273b-743e-4b8a-9478-c5b8331c65cd"), "25 - 34 years old", 2 },
                    { new Guid("47b35c69-fbcb-4f0c-a537-bad141a85e28"), "35 - 44 years old", 3 },
                    { new Guid("c9afd44c-758d-4946-a68e-f32d6760d1dd"), "45 - 54 years old", 4 },
                    { new Guid("34115fd9-832b-4f58-97f5-5c67623b202c"), "55 - 64 years old", 5 },
                    { new Guid("0bdf2a34-34da-4dfd-93dc-90fddcd57bb7"), "65+ years old", 6 }
                });

            migrationBuilder.InsertData(
                table: "ConfidenceGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("ae62b585-cd21-46e8-b2cc-5a28bc23910b"), "Full confidence", 5 },
                    { new Guid("14863183-9c0e-4b33-9339-4b7903143ded"), "Moderate confidence", 3 },
                    { new Guid("05b935e7-bb6d-4645-aa44-52e25bc0e00d"), "High confidence", 4 },
                    { new Guid("ef4d8973-a168-4668-8b0e-bb226c00e508"), "No confidence", 1 },
                    { new Guid("d933469b-b4a1-4ab7-9dbf-00c447374576"), "Low confidence", 2 }
                });

            migrationBuilder.InsertData(
                table: "EducationGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("0b671089-76a3-4496-90ad-c169f2fe1d65"), "Primary Education", 1 },
                    { new Guid("6bb894a2-c47f-4d7b-9b1e-af6d841f7b3a"), "Secondary Education", 2 },
                    { new Guid("aa44818e-974b-4e03-b394-8fb2a42a2a87"), "Vocational training", 3 },
                    { new Guid("929ecf33-5b1b-4717-8285-37b1083604ec"), "Bachelor degree or equivalent", 4 },
                    { new Guid("e06489aa-ba0d-4d89-99d3-f9638c2e5e1e"), "Postgraduate Master", 5 },
                    { new Guid("a65e41cc-a04c-43a9-aedc-ba0239abb392"), "PhD", 6 }
                });

            migrationBuilder.InsertData(
                table: "EvaluationResponses",
                columns: new[] { "Id", "Description", "IsCorrect", "ResponseOrder", "ScenarioId", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("4f1617d6-3d77-4e49-af53-5ec4b46a8c8a"), "Ignore and block", false, 3, 4, "Ignore the email and remove the recruiter from your LinkedIn.", 3 },
                    { new Guid("feaaacac-32f5-45d7-ba2c-d7f061b77a0d"), "Use the number to arrange a meeting", true, 4, 4, "Give the recruiter a call on one of the two numbers provided and arrange to meet up with him to discuss how he can help you.", 4 },
                    { new Guid("ff9afbeb-a6b4-45a8-8bf4-5519797605eb"), "Accept immediately and provide too much data", false, 2, 4, "You have been job hunting for ages and see this as a blessing in disguise. You reply to the email saying that you would appreciate his help and attach a copy of your CV, a copy of your ID and a link to your GitHub account. (Since you know he will most likely request all this information anyway.", 2 },
                    { new Guid("6a53fa9c-5e87-4470-8385-5063dba8760a"), "Click on the links and decide later", false, 1, 4, "Click on the links provided, and have a look at the company’s online profile as well as reviews left by others. If all seems good, get in contact with the recruiter.", 1 },
                    { new Guid("8119a75b-e3a0-4abe-8cb8-86f627f43988"), "Accept immediately", false, 3, 3, "Instantly provide her with your login details and wish her a merry Christmas.", 3 },
                    { new Guid("e34f1f12-d0d3-4b33-9825-9fc3ec0b27b3"), "Refer to colleague", false, 2, 3, "Ask her to contact one of your colleagues since you are on holiday.", 2 },
                    { new Guid("4bb4b265-2a53-4608-b1c3-d98c41431eb3"), "Refuse immidately", true, 1, 3, "Refuse to help her entirely and hang up the phone.", 1 },
                    { new Guid("52653f8a-ac18-4c9a-b5b7-1bc617afd463"), "Ask more questions and decide later", false, 4, 3, "Ask her a few complementary questions and based on her answers either provide her with your login details or don’t provide her with any information.", 4 }
                });

            migrationBuilder.InsertData(
                table: "EvaluationScenarios",
                columns: new[] { "Id", "Context", "Feedback", "ScenarioId" },
                values: new object[,]
                {
                    { new Guid("6586dce3-3a2a-4fbc-80dd-f31fcbe35554"), "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is very sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what user-name you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?", "Placeholder feedback 1", 3 },
                    { new Guid("aac562df-33e5-41a3-bf79-218cbe2ac449"), "You are a Computer Science Honours student at UCT, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have a big network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in Cape Town. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position as of yet post studies? I’d be keen to have a chat with you to find out what It is that really interests you so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?", "Placeholder feedback 2", 4 }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "Description", "ResponseOrder", "ScenarioId", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("97ca29d5-fbf5-42d6-a97d-230582b33b51"), "Click on the links and decide later", 1, 2, "Click on the links provided, and have a look at the company’s online profile as well as reviews left by others. If all seems good, get in contact with the recruiter.", 1 },
                    { new Guid("cde1cf30-b471-410d-9e5f-8e74f0904a80"), "Use the number to arrange a meeting", 4, 2, "Give the recruiter a call on one of the two numbers provided and arrange to meet up with him to discuss how he can help you.", 4 },
                    { new Guid("b4d4fbf1-c5fe-49c5-8545-c21841e5f483"), "Ignore and block", 3, 2, "Ignore the email and remove the recruiter from your LinkedIn.", 3 },
                    { new Guid("2249cede-f128-4a27-b8a8-be5d787d00e9"), "Accept immediately and provide too much data", 2, 2, "You have been job hunting for ages and see this as a blessing in disguise. You reply to the email saying that you would appreciate his help and attach a copy of your CV, a copy of your ID and a link to your GitHub account. (Since you know he will most likely request all this information anyway.", 2 },
                    { new Guid("0c70e4a1-14ca-415e-b1d0-3f96947028fc"), "Ask more questions and decide later", 4, 1, "Ask her a few complementary questions and based on her answers either provide her with your login details or don’t provide her with any information.", 4 },
                    { new Guid("0caac71c-4b04-4f64-9259-b9e3ca3a5e83"), "Accept immediately", 3, 1, "Instantly provide her with your login details and wish her a merry Christmas.", 3 },
                    { new Guid("d29ca794-2e72-4d65-91e0-44c673141ac7"), "Refer to colleague", 2, 1, "Ask her to contact one of your colleagues since you are on holiday.", 2 },
                    { new Guid("46a3bbc8-97b3-4a93-9aca-29517ec85f38"), "Refuse immidately", 1, 1, "Refuse to help her entirely and hang up the phone.", 1 }
                });

            migrationBuilder.InsertData(
                table: "Scenarios",
                columns: new[] { "Id", "Context", "ScenarioId" },
                values: new object[,]
                {
                    { new Guid("d5134dc8-c041-4e11-bd68-4729093d3043"), "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is very sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what user-name you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?", 1 },
                    { new Guid("635d6bed-d073-49e9-b8b0-8d36de086a05"), "You are a Computer Science Honours student at UCT, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have a big network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in Cape Town. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position as of yet post studies? I’d be keen to have a chat with you to find out what It is that really interests you so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?", 2 }
                });

            migrationBuilder.InsertData(
                table: "StudyGroups",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("eb20a3b8-6e0b-4d9b-9a61-cbbaf116efad"), "SEADM" },
                    { new Guid("4315488d-b78f-4bf2-a14b-231961088327"), "Feedback" }
                });

            migrationBuilder.InsertData(
                table: "YearGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("734aa23d-2c96-4b49-aee2-11343344eb2a"), "2 - 3 years", 2 },
                    { new Guid("54e45f31-03ba-4d5c-bf21-c922b5d2bafd"), "4 - 5 years", 3 },
                    { new Guid("396dce7c-2d8a-40db-a66c-4f59518772ca"), "1 year or less", 1 }
                });

            migrationBuilder.InsertData(
                table: "YearGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[] { new Guid("9f489fcd-858f-4c96-8b41-5c3a6edbdc3c"), "6 years or more", 4 });

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
                name: "AnswersBaseline");

            migrationBuilder.DropTable(
                name: "ConfidenceGroups");

            migrationBuilder.DropTable(
                name: "EducationGroups");

            migrationBuilder.DropTable(
                name: "EvaluationResponses");

            migrationBuilder.DropTable(
                name: "EvaluationScenarios");

            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "ParticipantSurveys");

            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Scenarios");

            migrationBuilder.DropTable(
                name: "YearGroups");

            migrationBuilder.DropTable(
                name: "StudyGroups");
        }
    }
}
