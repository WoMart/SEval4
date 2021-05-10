using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SEval4.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgeGroup",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgeGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConfidenceGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationGroups", x => x.Id);
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
                    ScenarioId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Context = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correct = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scenarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YearGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScenarioResponse",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correct = table.Column<bool>(type: "bit", nullable: false),
                    ScenarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScenarioResponse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScenarioResponse_Scenarios_ScenarioId",
                        column: x => x.ScenarioId,
                        principalTable: "Scenarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AgeGroup",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("fbceff88-854e-4da4-b159-c6c48bcba856"), "18 - 24 years old", 1 },
                    { new Guid("e55fbf1d-d1ce-41d6-9935-45ba566723d8"), "25 - 34 years old", 2 },
                    { new Guid("6d9fde53-3731-4eff-8ae2-bfe6e22de3bc"), "35 - 44 years old", 3 },
                    { new Guid("da2d06f9-910b-4b89-a4da-9d7d9d36e030"), "45 - 54 years old", 4 },
                    { new Guid("6e0caf8a-89fd-4655-861f-900b7e66a5f4"), "55 - 64 years old", 5 },
                    { new Guid("98f13767-1a05-4afb-b5fb-3e6bb2dc97db"), "65+ years old", 6 }
                });

            migrationBuilder.InsertData(
                table: "ConfidenceGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("150f60f8-18fe-4aee-8fa1-f9071d77c9aa"), "No confidence", 1 },
                    { new Guid("5eef0798-b6c8-4c5e-a046-aed91e237805"), "Low confidence", 2 },
                    { new Guid("94932c31-30a7-45dc-a5d4-2ebb57d9148e"), "Moderate confidence", 3 },
                    { new Guid("20cdd616-ef9e-4774-b64b-2711b189e521"), "High confidence", 4 },
                    { new Guid("b51570f3-baf1-4454-b4a2-3e42793664c2"), "Full confidence", 5 }
                });

            migrationBuilder.InsertData(
                table: "EducationGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("a21f829e-0eb6-4909-ac05-8b9415187125"), "PhD", 6 },
                    { new Guid("ba0950e5-39d5-454d-8e96-7d81c4654da4"), "Bachelor degree or equivalent", 4 },
                    { new Guid("c6b531b6-8085-48ca-8491-7da72e5dd81e"), "Postgraduate Master", 5 },
                    { new Guid("fd9ed52e-7ebf-4e9f-a5b5-2ac1fb8f730b"), "Secondary Education", 2 },
                    { new Guid("9edcf271-8515-4637-a541-a9f20e00fdd8"), "Primary Education", 1 },
                    { new Guid("2efb75a2-3f15-4c4c-bccd-38134389f8f9"), "Vocational training", 3 }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "Description", "ScenarioId", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("4c0f63da-13c8-4af5-97c7-06f3370f3b94"), "Use the number to arrange a meeting", 2, "Give the recruiter a call on one of the two numbers provided and arrange to meet up with him to discuss how he can help you.", 4 },
                    { new Guid("d680492b-b65d-40a2-b0a7-ae8f23485689"), "Ignore and block", 2, "Ignore the email and remove the recruiter from your LinkedIn.", 3 },
                    { new Guid("364e454c-81e6-4856-be8b-015e90095756"), "Click on the links and decide later", 2, "Click on the links provided, and have a look at the company’s online profile as well as reviews left by others. If all seems good, get in contact with the recruiter.", 1 },
                    { new Guid("8e9ba918-9228-425f-86a5-24086e07679c"), "Accept immediately and provide too much data", 2, "You have been job hunting for ages and see this as a blessing in disguise. You reply to the email saying that you would appreciate his help and attach a copy of your CV, a copy of your ID and a link to your GitHub account. (Since you know he will most likely request all this information anyway.", 2 },
                    { new Guid("990426e8-a356-4fc0-bb7f-b5a9df8e6989"), "Accept immediately", 1, "Instantly provide her with your login details and wish her a merry Christmas.", 3 },
                    { new Guid("ea35d02d-a22c-438b-8b72-3cd32e29eda5"), "Refer to colleague", 1, "Ask her to contact one of your colleagues since you are on holiday.", 2 },
                    { new Guid("30f0c2ae-e42f-43c8-8a52-591f3a3af358"), "Refuse immidately", 1, "Refuse to help her entirely and hang up the phone.", 1 },
                    { new Guid("5c13e11c-567e-4d8c-a584-fb8ea0d7dbb8"), "Ask more questions and decide later", 1, "Ask her a few complementary questions and based on her answers either provide her with your login details or don’t provide her with any information.", 4 }
                });

            migrationBuilder.InsertData(
                table: "Scenarios",
                columns: new[] { "Id", "Context", "Correct", "ScenarioId" },
                values: new object[,]
                {
                    { new Guid("606f87b1-f1e0-4456-a982-76023ef25f78"), "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is very sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what user-name you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?", new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { new Guid("8623775d-66ee-45ff-b516-8d14d66447d0"), "You are a Computer Science Honours student at UCT, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have a big network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in Cape Town. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position as of yet post studies? I’d be keen to have a chat with you to find out what It is that really interests you so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?", new Guid("00000000-0000-0000-0000-000000000000"), 2 }
                });

            migrationBuilder.InsertData(
                table: "YearGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("0cdf0a12-9466-4b3e-84ad-5929489e4a36"), "4 - 5 years", 3 },
                    { new Guid("7e5c127f-27fb-4ac4-a502-e8a38a037294"), "1 year or less", 1 },
                    { new Guid("556de82e-2fe0-469e-88d8-59416534629d"), "2 - 3 years", 2 },
                    { new Guid("9bc97848-387b-412d-8bc1-39e07ff3105a"), "6 years or more", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScenarioResponse_ScenarioId",
                table: "ScenarioResponse",
                column: "ScenarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgeGroup");

            migrationBuilder.DropTable(
                name: "ConfidenceGroups");

            migrationBuilder.DropTable(
                name: "EducationGroups");

            migrationBuilder.DropTable(
                name: "ParticipantSurveys");

            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "ScenarioResponse");

            migrationBuilder.DropTable(
                name: "YearGroups");

            migrationBuilder.DropTable(
                name: "Scenarios");
        }
    }
}
