using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SEval4.Migrations
{
    public partial class AddStudyGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participants_StudyGroup_StudyGroupId",
                table: "Participants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudyGroup",
                table: "StudyGroup");

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("426559bd-6817-43ea-bcbd-593328f207f2"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("4b5aa3eb-8d47-4220-a67d-3d153cc3c62d"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("5de6f087-8691-4b8c-8904-fa9015d2d5cf"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("655b5989-59ff-43d1-8df7-f14feafaa009"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("7f74ac0d-7253-4066-838a-7daf3ae2fb06"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("dfbe2dd3-9f77-42aa-9aae-2da8e3b60700"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("492c1193-d6b4-496d-bab1-70065dd38724"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("4e953623-1a0c-4ad7-b4ba-d9b441567d6a"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("51507db6-e831-4959-bfac-dd179440e765"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("595b339d-c38c-40b1-8c9d-a11ef4345cd3"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("d280da5b-0e3a-4f3a-864d-f942ef28b045"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("03f2f430-e254-48a2-8ad4-3122193e8d7a"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("233b1869-e717-4d49-97a0-81cdf1745fe6"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("2a87d5ea-60e1-4b69-840a-e3eda619814c"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("5307a0fa-c116-4f56-b29e-a53d5150e28e"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("95769ba7-70a7-40d0-a3d9-4891634aabef"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("96706ed3-11fc-4b82-aaf1-784cef720450"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("07b4a136-b298-443f-b0f7-2619c9f0821e"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("1f65e9ba-c978-4be5-a26d-7dffbef4ab31"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("1fbc387d-504b-45e1-8427-0574d9cd60f8"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("3808cc4f-af21-4b5f-89ce-76c566835694"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("3b2cbaf3-0e85-4beb-a890-c981285f4404"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("8bb49d89-bbca-4bda-b3a7-ba8dd88cbd6f"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("a03212a7-5f63-4197-8e11-5b2508937dcc"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("e68c7733-b6a6-48a8-a2bb-085741481220"));

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: new Guid("15053977-23d0-469c-a61e-6e7861aa66bf"));

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: new Guid("4468f5fa-57fb-44e8-adab-d3327493ae7a"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("1ff6af72-4cde-4b83-847e-c12afbb1c9e3"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("38948532-785e-439c-97a0-06e38123e5fd"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("d635f9eb-8740-4126-98c3-5773bbbbd69f"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("d8daa45b-aec3-46ef-adbc-05e37146350a"));

            migrationBuilder.RenameTable(
                name: "StudyGroup",
                newName: "StudyGroups");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudyGroups",
                table: "StudyGroups",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AgeGroup",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("f2b0d3bc-21e1-4c01-aefa-4f90ea03047c"), "18 - 24 years old", 1 },
                    { new Guid("92409db9-0e06-436f-a921-271206ef7e19"), "25 - 34 years old", 2 },
                    { new Guid("6083d4fd-2b3a-4f3d-b9d8-fa185d7c107e"), "35 - 44 years old", 3 },
                    { new Guid("109ec0f4-6519-421d-a0b6-729309ec8121"), "45 - 54 years old", 4 },
                    { new Guid("ce5e0bf3-aba6-4b4e-b337-12acf35e08f6"), "55 - 64 years old", 5 },
                    { new Guid("c67ce582-f37c-402a-8572-d0d0a25f295b"), "65+ years old", 6 }
                });

            migrationBuilder.InsertData(
                table: "ConfidenceGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("14debf24-6def-429e-90af-0fbdcbd960f1"), "No confidence", 1 },
                    { new Guid("399d2bcc-5a8d-47bd-92a1-857442dabb9d"), "Low confidence", 2 },
                    { new Guid("ccf92c0b-dc37-49a1-89b5-7d399f4ad653"), "Moderate confidence", 3 },
                    { new Guid("b42c8b09-6b0c-4466-bc71-54dc56cd76f6"), "High confidence", 4 },
                    { new Guid("10890586-c0b5-4910-9021-083ab3190522"), "Full confidence", 5 }
                });

            migrationBuilder.InsertData(
                table: "EducationGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("0250f7c3-d991-4822-b532-6520d9182ed9"), "Postgraduate Master", 5 },
                    { new Guid("41f5050c-fadf-4610-a63f-7bf9c54675c0"), "Bachelor degree or equivalent", 4 },
                    { new Guid("b7a649a3-e69e-44a2-8a65-59002a08a353"), "PhD", 6 },
                    { new Guid("d234598a-49a3-4a6c-be5e-1d9671870088"), "Secondary Education", 2 },
                    { new Guid("860ce228-f578-43bd-9acf-45b7e3d9f643"), "Primary Education", 1 },
                    { new Guid("c106f076-9851-4379-985c-bb50fbc16dce"), "Vocational training", 3 }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "Description", "ResponseOrder", "ScenarioId", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("0f64a5fc-d9df-423a-a884-c7c3242141e8"), "Use the number to arrange a meeting", 4, 2, "Give the recruiter a call on one of the two numbers provided and arrange to meet up with him to discuss how he can help you.", 4 },
                    { new Guid("42e4ed4a-dad5-44ee-b126-5b1e833f35e6"), "Accept immediately and provide too much data", 2, 2, "You have been job hunting for ages and see this as a blessing in disguise. You reply to the email saying that you would appreciate his help and attach a copy of your CV, a copy of your ID and a link to your GitHub account. (Since you know he will most likely request all this information anyway.", 2 },
                    { new Guid("1b4f2071-8461-4626-9ee2-3a86f869ac05"), "Click on the links and decide later", 1, 2, "Click on the links provided, and have a look at the company’s online profile as well as reviews left by others. If all seems good, get in contact with the recruiter.", 1 },
                    { new Guid("fb9aafc7-7a64-4468-84b2-3fc67a8a42ff"), "Ignore and block", 3, 2, "Ignore the email and remove the recruiter from your LinkedIn.", 3 },
                    { new Guid("598bf1f5-dcc0-4969-9db3-2346edf8063b"), "Accept immediately", 3, 1, "Instantly provide her with your login details and wish her a merry Christmas.", 3 },
                    { new Guid("f83afa3f-7023-4362-9e1b-e1824970e293"), "Refer to colleague", 2, 1, "Ask her to contact one of your colleagues since you are on holiday.", 2 },
                    { new Guid("90009294-d831-4bc5-8470-edd6aff4d4cf"), "Refuse immidately", 1, 1, "Refuse to help her entirely and hang up the phone.", 1 },
                    { new Guid("2cf86068-8150-45a3-a0f1-270724f1d377"), "Ask more questions and decide later", 4, 1, "Ask her a few complementary questions and based on her answers either provide her with your login details or don’t provide her with any information.", 4 }
                });

            migrationBuilder.InsertData(
                table: "Scenarios",
                columns: new[] { "Id", "Context", "ScenarioId" },
                values: new object[,]
                {
                    { new Guid("dbcb1671-0860-4765-ae0d-6873f55a9513"), "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is very sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what user-name you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?", 1 },
                    { new Guid("dff7080a-21a0-462c-90f2-555bc52df16b"), "You are a Computer Science Honours student at UCT, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have a big network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in Cape Town. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position as of yet post studies? I’d be keen to have a chat with you to find out what It is that really interests you so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?", 2 }
                });

            migrationBuilder.InsertData(
                table: "StudyGroups",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "SEADM" },
                    { 2, "Feedback" }
                });

            migrationBuilder.InsertData(
                table: "YearGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("34f965c4-c4d0-430c-9eff-d6af3fe838f5"), "1 year or less", 1 },
                    { new Guid("95f91fdc-84fb-4d04-81ac-681509581c5a"), "2 - 3 years", 2 },
                    { new Guid("f84e29fc-e245-4a2f-b52c-bc55e7545b6a"), "4 - 5 years", 3 },
                    { new Guid("78af586f-27a7-4ff4-a681-262c59beedf6"), "6 years or more", 4 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Participants_StudyGroups_StudyGroupId",
                table: "Participants",
                column: "StudyGroupId",
                principalTable: "StudyGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Participants_StudyGroups_StudyGroupId",
                table: "Participants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudyGroups",
                table: "StudyGroups");

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("109ec0f4-6519-421d-a0b6-729309ec8121"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("6083d4fd-2b3a-4f3d-b9d8-fa185d7c107e"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("92409db9-0e06-436f-a921-271206ef7e19"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("c67ce582-f37c-402a-8572-d0d0a25f295b"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("ce5e0bf3-aba6-4b4e-b337-12acf35e08f6"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("f2b0d3bc-21e1-4c01-aefa-4f90ea03047c"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("10890586-c0b5-4910-9021-083ab3190522"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("14debf24-6def-429e-90af-0fbdcbd960f1"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("399d2bcc-5a8d-47bd-92a1-857442dabb9d"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("b42c8b09-6b0c-4466-bc71-54dc56cd76f6"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("ccf92c0b-dc37-49a1-89b5-7d399f4ad653"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("0250f7c3-d991-4822-b532-6520d9182ed9"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("41f5050c-fadf-4610-a63f-7bf9c54675c0"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("860ce228-f578-43bd-9acf-45b7e3d9f643"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("b7a649a3-e69e-44a2-8a65-59002a08a353"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("c106f076-9851-4379-985c-bb50fbc16dce"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("d234598a-49a3-4a6c-be5e-1d9671870088"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("0f64a5fc-d9df-423a-a884-c7c3242141e8"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("1b4f2071-8461-4626-9ee2-3a86f869ac05"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("2cf86068-8150-45a3-a0f1-270724f1d377"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("42e4ed4a-dad5-44ee-b126-5b1e833f35e6"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("598bf1f5-dcc0-4969-9db3-2346edf8063b"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("90009294-d831-4bc5-8470-edd6aff4d4cf"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("f83afa3f-7023-4362-9e1b-e1824970e293"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("fb9aafc7-7a64-4468-84b2-3fc67a8a42ff"));

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: new Guid("dbcb1671-0860-4765-ae0d-6873f55a9513"));

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: new Guid("dff7080a-21a0-462c-90f2-555bc52df16b"));

            migrationBuilder.DeleteData(
                table: "StudyGroups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudyGroups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("34f965c4-c4d0-430c-9eff-d6af3fe838f5"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("78af586f-27a7-4ff4-a681-262c59beedf6"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("95f91fdc-84fb-4d04-81ac-681509581c5a"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("f84e29fc-e245-4a2f-b52c-bc55e7545b6a"));

            migrationBuilder.RenameTable(
                name: "StudyGroups",
                newName: "StudyGroup");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudyGroup",
                table: "StudyGroup",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AgeGroup",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("7f74ac0d-7253-4066-838a-7daf3ae2fb06"), "18 - 24 years old", 1 },
                    { new Guid("426559bd-6817-43ea-bcbd-593328f207f2"), "25 - 34 years old", 2 },
                    { new Guid("dfbe2dd3-9f77-42aa-9aae-2da8e3b60700"), "35 - 44 years old", 3 },
                    { new Guid("4b5aa3eb-8d47-4220-a67d-3d153cc3c62d"), "45 - 54 years old", 4 },
                    { new Guid("655b5989-59ff-43d1-8df7-f14feafaa009"), "55 - 64 years old", 5 },
                    { new Guid("5de6f087-8691-4b8c-8904-fa9015d2d5cf"), "65+ years old", 6 }
                });

            migrationBuilder.InsertData(
                table: "ConfidenceGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("4e953623-1a0c-4ad7-b4ba-d9b441567d6a"), "No confidence", 1 },
                    { new Guid("d280da5b-0e3a-4f3a-864d-f942ef28b045"), "Low confidence", 2 },
                    { new Guid("595b339d-c38c-40b1-8c9d-a11ef4345cd3"), "Moderate confidence", 3 },
                    { new Guid("492c1193-d6b4-496d-bab1-70065dd38724"), "High confidence", 4 },
                    { new Guid("51507db6-e831-4959-bfac-dd179440e765"), "Full confidence", 5 }
                });

            migrationBuilder.InsertData(
                table: "EducationGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("233b1869-e717-4d49-97a0-81cdf1745fe6"), "PhD", 6 },
                    { new Guid("96706ed3-11fc-4b82-aaf1-784cef720450"), "Bachelor degree or equivalent", 4 },
                    { new Guid("03f2f430-e254-48a2-8ad4-3122193e8d7a"), "Postgraduate Master", 5 },
                    { new Guid("2a87d5ea-60e1-4b69-840a-e3eda619814c"), "Secondary Education", 2 },
                    { new Guid("5307a0fa-c116-4f56-b29e-a53d5150e28e"), "Primary Education", 1 },
                    { new Guid("95769ba7-70a7-40d0-a3d9-4891634aabef"), "Vocational training", 3 }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "Description", "ResponseOrder", "ScenarioId", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("3808cc4f-af21-4b5f-89ce-76c566835694"), "Use the number to arrange a meeting", 4, 2, "Give the recruiter a call on one of the two numbers provided and arrange to meet up with him to discuss how he can help you.", 4 },
                    { new Guid("1f65e9ba-c978-4be5-a26d-7dffbef4ab31"), "Ignore and block", 3, 2, "Ignore the email and remove the recruiter from your LinkedIn.", 3 },
                    { new Guid("e68c7733-b6a6-48a8-a2bb-085741481220"), "Click on the links and decide later", 1, 2, "Click on the links provided, and have a look at the company’s online profile as well as reviews left by others. If all seems good, get in contact with the recruiter.", 1 },
                    { new Guid("07b4a136-b298-443f-b0f7-2619c9f0821e"), "Accept immediately and provide too much data", 2, 2, "You have been job hunting for ages and see this as a blessing in disguise. You reply to the email saying that you would appreciate his help and attach a copy of your CV, a copy of your ID and a link to your GitHub account. (Since you know he will most likely request all this information anyway.", 2 },
                    { new Guid("1fbc387d-504b-45e1-8427-0574d9cd60f8"), "Accept immediately", 3, 1, "Instantly provide her with your login details and wish her a merry Christmas.", 3 },
                    { new Guid("a03212a7-5f63-4197-8e11-5b2508937dcc"), "Refer to colleague", 2, 1, "Ask her to contact one of your colleagues since you are on holiday.", 2 },
                    { new Guid("8bb49d89-bbca-4bda-b3a7-ba8dd88cbd6f"), "Refuse immidately", 1, 1, "Refuse to help her entirely and hang up the phone.", 1 },
                    { new Guid("3b2cbaf3-0e85-4beb-a890-c981285f4404"), "Ask more questions and decide later", 4, 1, "Ask her a few complementary questions and based on her answers either provide her with your login details or don’t provide her with any information.", 4 }
                });

            migrationBuilder.InsertData(
                table: "Scenarios",
                columns: new[] { "Id", "Context", "ScenarioId" },
                values: new object[,]
                {
                    { new Guid("15053977-23d0-469c-a61e-6e7861aa66bf"), "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is very sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what user-name you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?", 1 },
                    { new Guid("4468f5fa-57fb-44e8-adab-d3327493ae7a"), "You are a Computer Science Honours student at UCT, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have a big network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in Cape Town. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position as of yet post studies? I’d be keen to have a chat with you to find out what It is that really interests you so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?", 2 }
                });

            migrationBuilder.InsertData(
                table: "YearGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("d8daa45b-aec3-46ef-adbc-05e37146350a"), "4 - 5 years", 3 },
                    { new Guid("1ff6af72-4cde-4b83-847e-c12afbb1c9e3"), "1 year or less", 1 },
                    { new Guid("d635f9eb-8740-4126-98c3-5773bbbbd69f"), "2 - 3 years", 2 },
                    { new Guid("38948532-785e-439c-97a0-06e38123e5fd"), "6 years or more", 4 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Participants_StudyGroup_StudyGroupId",
                table: "Participants",
                column: "StudyGroupId",
                principalTable: "StudyGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
