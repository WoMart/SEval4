using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SEval4.Migrations
{
    public partial class AttemptCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("1b9d96af-c625-4e34-b25c-227832660b76"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("30618554-dd19-4021-8a63-a9d5706a4920"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("599ef3cc-921f-4e58-aae3-a603c29ca2b5"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("8a79f8fe-1e3a-42a9-81dd-1cbdbf865ba5"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("9c9ed31c-7a85-4f8e-bd49-fbb8df0c74e4"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("d4293612-6665-4def-9c0f-da7324aef565"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("0a121ac3-9ac9-4185-a0dc-29db3c56e746"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("5701e717-f805-4b32-bd1e-a7ae0c1cc7be"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("8856d38c-ea15-4360-aa68-1671964a884f"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("cbe4ca49-bc3d-4cc1-8d0f-cf4233d8ce31"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("fd913be2-3fa3-4e6d-8504-0344bbe01c4e"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("0896126e-4e3d-4567-b174-54402554635f"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("133f364d-66ea-44e3-b46a-56c4f5ab484f"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("23dce351-9446-4e2c-ac38-ac0ea2cafee9"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("2ad3d51d-4c6b-423a-b7df-11da2795377f"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("8b3a46c9-c0b9-493a-8e6e-ac6a0f3e3efe"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("efd1a898-ac12-40dd-b394-abb73adbba44"));

            migrationBuilder.DeleteData(
                table: "EvaluationResponses",
                keyColumn: "Id",
                keyValue: new Guid("1f81af6e-9db2-4865-a846-d7339222635f"));

            migrationBuilder.DeleteData(
                table: "EvaluationResponses",
                keyColumn: "Id",
                keyValue: new Guid("36fa4f22-243c-4636-8297-3e9cdc4025df"));

            migrationBuilder.DeleteData(
                table: "EvaluationResponses",
                keyColumn: "Id",
                keyValue: new Guid("3eaa6c30-0dec-4432-9587-87597d74e555"));

            migrationBuilder.DeleteData(
                table: "EvaluationResponses",
                keyColumn: "Id",
                keyValue: new Guid("6ade07e5-55fa-4e53-acbd-1b47fea7ff2e"));

            migrationBuilder.DeleteData(
                table: "EvaluationResponses",
                keyColumn: "Id",
                keyValue: new Guid("7e4f5519-e465-49f4-91b7-c8f010cf3bb6"));

            migrationBuilder.DeleteData(
                table: "EvaluationResponses",
                keyColumn: "Id",
                keyValue: new Guid("c66376b7-5002-490e-a932-280793819a37"));

            migrationBuilder.DeleteData(
                table: "EvaluationResponses",
                keyColumn: "Id",
                keyValue: new Guid("dea0532c-d1c3-46d8-96b3-43fc3411ba69"));

            migrationBuilder.DeleteData(
                table: "EvaluationResponses",
                keyColumn: "Id",
                keyValue: new Guid("e38c90a4-364a-4ab8-9848-f434e1b33d0f"));

            migrationBuilder.DeleteData(
                table: "EvaluationScenarios",
                keyColumn: "Id",
                keyValue: new Guid("04e8ae34-0882-4025-9a17-ce304a9e7eac"));

            migrationBuilder.DeleteData(
                table: "EvaluationScenarios",
                keyColumn: "Id",
                keyValue: new Guid("aaa12ca6-6ca0-4bf4-a0a4-852326b460a9"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("0c026a4e-716e-42ab-919c-cef660478456"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("1dc4369f-ae1b-49d7-be13-16381df3eed8"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("21a080c9-371d-4aa6-a6e4-b378d2a83342"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("230c66c1-4422-45b0-bd5b-ee55d419a5df"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("42508801-c27b-491f-9560-397f961b9a20"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("7ce2aa19-f5f3-4fde-8e67-01923fa33eff"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("96d211d8-8842-4fa6-953c-bb3c7d5517d4"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("b6b94b0a-69a5-407c-8d82-9445ab891554"));

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: new Guid("27b6dd72-7307-4d88-a81d-84404e95693f"));

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: new Guid("90df4edf-38ef-4e9a-8ccb-289a0d64de85"));

            migrationBuilder.DeleteData(
                table: "StudyGroups",
                keyColumn: "Id",
                keyValue: new Guid("81d9ee3f-d390-4fee-96e8-abf051c742f3"));

            migrationBuilder.DeleteData(
                table: "StudyGroups",
                keyColumn: "Id",
                keyValue: new Guid("d35fb420-bee2-481e-a312-03cfc3b6ac17"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("6bc6afff-79a8-4bce-abe5-db14c4af377c"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("95832783-be1d-4c27-9af7-049c0d9a647e"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("a1be7e30-df77-41d4-8566-89678266529f"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("d60cf323-f509-41ff-ad36-490b35384ed5"));

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

            migrationBuilder.InsertData(
                table: "AgeGroup",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("9f47c836-e5d7-44ea-a223-da377a838cf9"), "18 - 24 years old", 1 },
                    { new Guid("c260172a-2c29-4504-b2ea-fda3ff0d61b2"), "25 - 34 years old", 2 },
                    { new Guid("0ddc62c5-5540-4884-8c06-e1d54e76606b"), "35 - 44 years old", 3 },
                    { new Guid("34787ece-1b86-4578-8243-17881ec1dccf"), "45 - 54 years old", 4 },
                    { new Guid("c69ef278-02cf-4ec2-b899-d4045c1eb3fa"), "55 - 64 years old", 5 },
                    { new Guid("373ac374-1781-4529-ac57-35db02737901"), "65+ years old", 6 }
                });

            migrationBuilder.InsertData(
                table: "ConfidenceGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("96c9670a-4c5d-4d2b-b8a6-1f23017428b2"), "Full confidence", 5 },
                    { new Guid("d823a0a3-5bd4-4fe9-b9ed-1536ce6c108d"), "Moderate confidence", 3 },
                    { new Guid("a65ff1f3-985c-483b-b675-7721ec02dae7"), "High confidence", 4 },
                    { new Guid("62cb5532-e6be-4d51-a7ca-b6bc34e7e3c2"), "No confidence", 1 },
                    { new Guid("1688208a-2992-4a52-9b37-895ac007a4ea"), "Low confidence", 2 }
                });

            migrationBuilder.InsertData(
                table: "EducationGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("ac1605ce-24cf-4538-b4f2-574f3dae0044"), "Primary Education", 1 },
                    { new Guid("394941fc-1176-4811-ba2f-e6fcad7aeb3b"), "Secondary Education", 2 },
                    { new Guid("b2476f61-ade4-46b2-b9ab-1787358896ec"), "Vocational training", 3 },
                    { new Guid("69af8903-3bb2-4211-bf04-cfeeecf02518"), "Bachelor degree or equivalent", 4 },
                    { new Guid("0f71cfa5-1244-4d14-9e5b-2691684a8d4b"), "Postgraduate Master", 5 },
                    { new Guid("8922e1a9-fa76-4209-a51a-f7ac858b37e5"), "PhD", 6 }
                });

            migrationBuilder.InsertData(
                table: "EvaluationResponses",
                columns: new[] { "Id", "Description", "IsCorrect", "ResponseOrder", "ScenarioId", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("ce155ea0-68d2-4864-a572-bf95d46a8a16"), "Ignore and block", false, 3, 4, "Ignore the email and remove the recruiter from your LinkedIn.", 3 },
                    { new Guid("f3a19460-0d49-49ea-b669-3e925e283483"), "Use the number to arrange a meeting", true, 4, 4, "Give the recruiter a call on one of the two numbers provided and arrange to meet up with him to discuss how he can help you.", 4 },
                    { new Guid("dae0e48b-ae9f-493e-a6f4-009a987b9f53"), "Accept immediately and provide too much data", false, 2, 4, "You have been job hunting for ages and see this as a blessing in disguise. You reply to the email saying that you would appreciate his help and attach a copy of your CV, a copy of your ID and a link to your GitHub account. (Since you know he will most likely request all this information anyway.", 2 },
                    { new Guid("05669790-cc9b-4f58-8a7d-fb0c06ac59f6"), "Click on the links and decide later", false, 1, 4, "Click on the links provided, and have a look at the company’s online profile as well as reviews left by others. If all seems good, get in contact with the recruiter.", 1 },
                    { new Guid("72ef8266-1794-4fa4-88e7-4aef487c742f"), "Accept immediately", false, 3, 3, "Instantly provide her with your login details and wish her a merry Christmas.", 3 },
                    { new Guid("7c70bbca-629a-474b-ba5a-87bc1b691f5f"), "Refer to colleague", false, 2, 3, "Ask her to contact one of your colleagues since you are on holiday.", 2 },
                    { new Guid("a2cf87c8-a44d-4902-896c-c6c7f43ebafc"), "Refuse immidately", true, 1, 3, "Refuse to help her entirely and hang up the phone.", 1 },
                    { new Guid("84b38c5e-62e5-40b1-98f9-85db645f307a"), "Ask more questions and decide later", false, 4, 3, "Ask her a few complementary questions and based on her answers either provide her with your login details or don’t provide her with any information.", 4 }
                });

            migrationBuilder.InsertData(
                table: "EvaluationScenarios",
                columns: new[] { "Id", "Context", "Feedback", "ScenarioId" },
                values: new object[,]
                {
                    { new Guid("d232fbe2-f2cd-4381-bd01-723e91261188"), "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is very sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what user-name you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?", "Placeholder feedback 1", 3 },
                    { new Guid("f989bc41-58cd-4c9e-be15-87f07ba3f4e2"), "You are a Computer Science Honours student at UCT, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have a big network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in Cape Town. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position as of yet post studies? I’d be keen to have a chat with you to find out what It is that really interests you so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?", "Placeholder feedback 2", 4 }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "Description", "ResponseOrder", "ScenarioId", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("ee7f35d1-0002-4a89-b0bc-81e568d6ee4d"), "Click on the links and decide later", 1, 2, "Click on the links provided, and have a look at the company’s online profile as well as reviews left by others. If all seems good, get in contact with the recruiter.", 1 },
                    { new Guid("62438fb5-e219-4421-a537-1f7df41d771e"), "Use the number to arrange a meeting", 4, 2, "Give the recruiter a call on one of the two numbers provided and arrange to meet up with him to discuss how he can help you.", 4 },
                    { new Guid("5def78b9-90d5-4743-bce6-60604c70291a"), "Ignore and block", 3, 2, "Ignore the email and remove the recruiter from your LinkedIn.", 3 },
                    { new Guid("103da0b3-3e1b-46d8-8c7f-a043fd210fee"), "Accept immediately and provide too much data", 2, 2, "You have been job hunting for ages and see this as a blessing in disguise. You reply to the email saying that you would appreciate his help and attach a copy of your CV, a copy of your ID and a link to your GitHub account. (Since you know he will most likely request all this information anyway.", 2 },
                    { new Guid("3609b4a6-c08d-47cb-a378-f8bbc3afc30b"), "Ask more questions and decide later", 4, 1, "Ask her a few complementary questions and based on her answers either provide her with your login details or don’t provide her with any information.", 4 },
                    { new Guid("43f394b7-b326-4b2f-b5f1-6b54a83344c8"), "Accept immediately", 3, 1, "Instantly provide her with your login details and wish her a merry Christmas.", 3 },
                    { new Guid("2a795674-9935-4a46-83f3-4f44e0e47b31"), "Refer to colleague", 2, 1, "Ask her to contact one of your colleagues since you are on holiday.", 2 },
                    { new Guid("646971cc-2759-4b8d-ac1d-6ca3bd5ce79c"), "Refuse immidately", 1, 1, "Refuse to help her entirely and hang up the phone.", 1 }
                });

            migrationBuilder.InsertData(
                table: "Scenarios",
                columns: new[] { "Id", "Context", "ScenarioId" },
                values: new object[,]
                {
                    { new Guid("d92818a8-1283-47c7-82be-560e83c84a79"), "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is very sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what user-name you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?", 1 },
                    { new Guid("779559ff-8dc8-4d99-913a-79d1addf1048"), "You are a Computer Science Honours student at UCT, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have a big network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in Cape Town. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position as of yet post studies? I’d be keen to have a chat with you to find out what It is that really interests you so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?", 2 }
                });

            migrationBuilder.InsertData(
                table: "StudyGroups",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("12b57df9-b900-4b48-ae3d-3a242d200f57"), "SEADM" },
                    { new Guid("39d0951e-7111-4916-aef1-8c3058934777"), "Feedback" }
                });

            migrationBuilder.InsertData(
                table: "YearGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("903ad865-2333-4d7b-892b-c67d0feea98a"), "2 - 3 years", 2 },
                    { new Guid("b620b4df-dd3c-4f25-928d-b16909a064e5"), "4 - 5 years", 3 },
                    { new Guid("a21d4d3c-4afe-4c54-b6d3-81b977fb4ad3"), "1 year or less", 1 }
                });

            migrationBuilder.InsertData(
                table: "YearGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[] { new Guid("2f512fe8-c493-4b95-8478-27351adc98d2"), "6 years or more", 4 });

            migrationBuilder.CreateIndex(
                name: "IX_AttemptCounts_UserId",
                table: "AttemptCounts",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttemptCounts");

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("0ddc62c5-5540-4884-8c06-e1d54e76606b"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("34787ece-1b86-4578-8243-17881ec1dccf"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("373ac374-1781-4529-ac57-35db02737901"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("9f47c836-e5d7-44ea-a223-da377a838cf9"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("c260172a-2c29-4504-b2ea-fda3ff0d61b2"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("c69ef278-02cf-4ec2-b899-d4045c1eb3fa"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("1688208a-2992-4a52-9b37-895ac007a4ea"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("62cb5532-e6be-4d51-a7ca-b6bc34e7e3c2"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("96c9670a-4c5d-4d2b-b8a6-1f23017428b2"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("a65ff1f3-985c-483b-b675-7721ec02dae7"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("d823a0a3-5bd4-4fe9-b9ed-1536ce6c108d"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("0f71cfa5-1244-4d14-9e5b-2691684a8d4b"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("394941fc-1176-4811-ba2f-e6fcad7aeb3b"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("69af8903-3bb2-4211-bf04-cfeeecf02518"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("8922e1a9-fa76-4209-a51a-f7ac858b37e5"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("ac1605ce-24cf-4538-b4f2-574f3dae0044"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("b2476f61-ade4-46b2-b9ab-1787358896ec"));

            migrationBuilder.DeleteData(
                table: "EvaluationResponses",
                keyColumn: "Id",
                keyValue: new Guid("05669790-cc9b-4f58-8a7d-fb0c06ac59f6"));

            migrationBuilder.DeleteData(
                table: "EvaluationResponses",
                keyColumn: "Id",
                keyValue: new Guid("72ef8266-1794-4fa4-88e7-4aef487c742f"));

            migrationBuilder.DeleteData(
                table: "EvaluationResponses",
                keyColumn: "Id",
                keyValue: new Guid("7c70bbca-629a-474b-ba5a-87bc1b691f5f"));

            migrationBuilder.DeleteData(
                table: "EvaluationResponses",
                keyColumn: "Id",
                keyValue: new Guid("84b38c5e-62e5-40b1-98f9-85db645f307a"));

            migrationBuilder.DeleteData(
                table: "EvaluationResponses",
                keyColumn: "Id",
                keyValue: new Guid("a2cf87c8-a44d-4902-896c-c6c7f43ebafc"));

            migrationBuilder.DeleteData(
                table: "EvaluationResponses",
                keyColumn: "Id",
                keyValue: new Guid("ce155ea0-68d2-4864-a572-bf95d46a8a16"));

            migrationBuilder.DeleteData(
                table: "EvaluationResponses",
                keyColumn: "Id",
                keyValue: new Guid("dae0e48b-ae9f-493e-a6f4-009a987b9f53"));

            migrationBuilder.DeleteData(
                table: "EvaluationResponses",
                keyColumn: "Id",
                keyValue: new Guid("f3a19460-0d49-49ea-b669-3e925e283483"));

            migrationBuilder.DeleteData(
                table: "EvaluationScenarios",
                keyColumn: "Id",
                keyValue: new Guid("d232fbe2-f2cd-4381-bd01-723e91261188"));

            migrationBuilder.DeleteData(
                table: "EvaluationScenarios",
                keyColumn: "Id",
                keyValue: new Guid("f989bc41-58cd-4c9e-be15-87f07ba3f4e2"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("103da0b3-3e1b-46d8-8c7f-a043fd210fee"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("2a795674-9935-4a46-83f3-4f44e0e47b31"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("3609b4a6-c08d-47cb-a378-f8bbc3afc30b"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("43f394b7-b326-4b2f-b5f1-6b54a83344c8"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("5def78b9-90d5-4743-bce6-60604c70291a"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("62438fb5-e219-4421-a537-1f7df41d771e"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("646971cc-2759-4b8d-ac1d-6ca3bd5ce79c"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("ee7f35d1-0002-4a89-b0bc-81e568d6ee4d"));

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: new Guid("779559ff-8dc8-4d99-913a-79d1addf1048"));

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: new Guid("d92818a8-1283-47c7-82be-560e83c84a79"));

            migrationBuilder.DeleteData(
                table: "StudyGroups",
                keyColumn: "Id",
                keyValue: new Guid("12b57df9-b900-4b48-ae3d-3a242d200f57"));

            migrationBuilder.DeleteData(
                table: "StudyGroups",
                keyColumn: "Id",
                keyValue: new Guid("39d0951e-7111-4916-aef1-8c3058934777"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("2f512fe8-c493-4b95-8478-27351adc98d2"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("903ad865-2333-4d7b-892b-c67d0feea98a"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("a21d4d3c-4afe-4c54-b6d3-81b977fb4ad3"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("b620b4df-dd3c-4f25-928d-b16909a064e5"));

            migrationBuilder.InsertData(
                table: "AgeGroup",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("8a79f8fe-1e3a-42a9-81dd-1cbdbf865ba5"), "18 - 24 years old", 1 },
                    { new Guid("1b9d96af-c625-4e34-b25c-227832660b76"), "25 - 34 years old", 2 },
                    { new Guid("d4293612-6665-4def-9c0f-da7324aef565"), "35 - 44 years old", 3 },
                    { new Guid("9c9ed31c-7a85-4f8e-bd49-fbb8df0c74e4"), "45 - 54 years old", 4 },
                    { new Guid("599ef3cc-921f-4e58-aae3-a603c29ca2b5"), "55 - 64 years old", 5 },
                    { new Guid("30618554-dd19-4021-8a63-a9d5706a4920"), "65+ years old", 6 }
                });

            migrationBuilder.InsertData(
                table: "ConfidenceGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("5701e717-f805-4b32-bd1e-a7ae0c1cc7be"), "Full confidence", 5 },
                    { new Guid("fd913be2-3fa3-4e6d-8504-0344bbe01c4e"), "Moderate confidence", 3 },
                    { new Guid("cbe4ca49-bc3d-4cc1-8d0f-cf4233d8ce31"), "High confidence", 4 },
                    { new Guid("8856d38c-ea15-4360-aa68-1671964a884f"), "No confidence", 1 },
                    { new Guid("0a121ac3-9ac9-4185-a0dc-29db3c56e746"), "Low confidence", 2 }
                });

            migrationBuilder.InsertData(
                table: "EducationGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("2ad3d51d-4c6b-423a-b7df-11da2795377f"), "Primary Education", 1 },
                    { new Guid("8b3a46c9-c0b9-493a-8e6e-ac6a0f3e3efe"), "Secondary Education", 2 },
                    { new Guid("133f364d-66ea-44e3-b46a-56c4f5ab484f"), "Vocational training", 3 },
                    { new Guid("0896126e-4e3d-4567-b174-54402554635f"), "Bachelor degree or equivalent", 4 },
                    { new Guid("23dce351-9446-4e2c-ac38-ac0ea2cafee9"), "Postgraduate Master", 5 },
                    { new Guid("efd1a898-ac12-40dd-b394-abb73adbba44"), "PhD", 6 }
                });

            migrationBuilder.InsertData(
                table: "EvaluationResponses",
                columns: new[] { "Id", "Description", "IsCorrect", "ResponseOrder", "ScenarioId", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("c66376b7-5002-490e-a932-280793819a37"), "Ignore and block", false, 3, 4, "Ignore the email and remove the recruiter from your LinkedIn.", 3 },
                    { new Guid("3eaa6c30-0dec-4432-9587-87597d74e555"), "Use the number to arrange a meeting", true, 4, 4, "Give the recruiter a call on one of the two numbers provided and arrange to meet up with him to discuss how he can help you.", 4 },
                    { new Guid("e38c90a4-364a-4ab8-9848-f434e1b33d0f"), "Accept immediately and provide too much data", false, 2, 4, "You have been job hunting for ages and see this as a blessing in disguise. You reply to the email saying that you would appreciate his help and attach a copy of your CV, a copy of your ID and a link to your GitHub account. (Since you know he will most likely request all this information anyway.", 2 },
                    { new Guid("36fa4f22-243c-4636-8297-3e9cdc4025df"), "Click on the links and decide later", false, 1, 4, "Click on the links provided, and have a look at the company’s online profile as well as reviews left by others. If all seems good, get in contact with the recruiter.", 1 },
                    { new Guid("7e4f5519-e465-49f4-91b7-c8f010cf3bb6"), "Accept immediately", false, 3, 3, "Instantly provide her with your login details and wish her a merry Christmas.", 3 },
                    { new Guid("1f81af6e-9db2-4865-a846-d7339222635f"), "Refer to colleague", false, 2, 3, "Ask her to contact one of your colleagues since you are on holiday.", 2 },
                    { new Guid("dea0532c-d1c3-46d8-96b3-43fc3411ba69"), "Refuse immidately", true, 1, 3, "Refuse to help her entirely and hang up the phone.", 1 },
                    { new Guid("6ade07e5-55fa-4e53-acbd-1b47fea7ff2e"), "Ask more questions and decide later", false, 4, 3, "Ask her a few complementary questions and based on her answers either provide her with your login details or don’t provide her with any information.", 4 }
                });

            migrationBuilder.InsertData(
                table: "EvaluationScenarios",
                columns: new[] { "Id", "Context", "Feedback", "ScenarioId" },
                values: new object[,]
                {
                    { new Guid("04e8ae34-0882-4025-9a17-ce304a9e7eac"), "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is very sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what user-name you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?", "Placeholder feedback 1", 3 },
                    { new Guid("aaa12ca6-6ca0-4bf4-a0a4-852326b460a9"), "You are a Computer Science Honours student at UCT, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have a big network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in Cape Town. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position as of yet post studies? I’d be keen to have a chat with you to find out what It is that really interests you so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?", "Placeholder feedback 2", 4 }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "Description", "ResponseOrder", "ScenarioId", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("b6b94b0a-69a5-407c-8d82-9445ab891554"), "Click on the links and decide later", 1, 2, "Click on the links provided, and have a look at the company’s online profile as well as reviews left by others. If all seems good, get in contact with the recruiter.", 1 },
                    { new Guid("230c66c1-4422-45b0-bd5b-ee55d419a5df"), "Use the number to arrange a meeting", 4, 2, "Give the recruiter a call on one of the two numbers provided and arrange to meet up with him to discuss how he can help you.", 4 },
                    { new Guid("0c026a4e-716e-42ab-919c-cef660478456"), "Ignore and block", 3, 2, "Ignore the email and remove the recruiter from your LinkedIn.", 3 },
                    { new Guid("42508801-c27b-491f-9560-397f961b9a20"), "Accept immediately and provide too much data", 2, 2, "You have been job hunting for ages and see this as a blessing in disguise. You reply to the email saying that you would appreciate his help and attach a copy of your CV, a copy of your ID and a link to your GitHub account. (Since you know he will most likely request all this information anyway.", 2 },
                    { new Guid("1dc4369f-ae1b-49d7-be13-16381df3eed8"), "Ask more questions and decide later", 4, 1, "Ask her a few complementary questions and based on her answers either provide her with your login details or don’t provide her with any information.", 4 },
                    { new Guid("96d211d8-8842-4fa6-953c-bb3c7d5517d4"), "Accept immediately", 3, 1, "Instantly provide her with your login details and wish her a merry Christmas.", 3 },
                    { new Guid("7ce2aa19-f5f3-4fde-8e67-01923fa33eff"), "Refer to colleague", 2, 1, "Ask her to contact one of your colleagues since you are on holiday.", 2 },
                    { new Guid("21a080c9-371d-4aa6-a6e4-b378d2a83342"), "Refuse immidately", 1, 1, "Refuse to help her entirely and hang up the phone.", 1 }
                });

            migrationBuilder.InsertData(
                table: "Scenarios",
                columns: new[] { "Id", "Context", "ScenarioId" },
                values: new object[,]
                {
                    { new Guid("90df4edf-38ef-4e9a-8ccb-289a0d64de85"), "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is very sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what user-name you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?", 1 },
                    { new Guid("27b6dd72-7307-4d88-a81d-84404e95693f"), "You are a Computer Science Honours student at UCT, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have a big network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in Cape Town. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position as of yet post studies? I’d be keen to have a chat with you to find out what It is that really interests you so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?", 2 }
                });

            migrationBuilder.InsertData(
                table: "StudyGroups",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("81d9ee3f-d390-4fee-96e8-abf051c742f3"), "SEADM" },
                    { new Guid("d35fb420-bee2-481e-a312-03cfc3b6ac17"), "Feedback" }
                });

            migrationBuilder.InsertData(
                table: "YearGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("d60cf323-f509-41ff-ad36-490b35384ed5"), "2 - 3 years", 2 },
                    { new Guid("6bc6afff-79a8-4bce-abe5-db14c4af377c"), "4 - 5 years", 3 },
                    { new Guid("95832783-be1d-4c27-9af7-049c0d9a647e"), "1 year or less", 1 }
                });

            migrationBuilder.InsertData(
                table: "YearGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[] { new Guid("a1be7e30-df77-41d4-8566-89678266529f"), "6 years or more", 4 });
        }
    }
}
