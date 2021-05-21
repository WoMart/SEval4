using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SEval4.Migrations
{
    public partial class TestEvalGame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "Feedback",
                table: "Scenarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCorrect",
                table: "Responses",
                type: "bit",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AgeGroup",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("13ae1545-c92f-4ba1-8c90-5327b1ee1cf7"), "18 - 24 years old", 1 },
                    { new Guid("75a66b53-e787-4f46-bab9-c2b3846402c0"), "25 - 34 years old", 2 },
                    { new Guid("a760b88e-2204-498b-82b2-23ac9911cf36"), "35 - 44 years old", 3 },
                    { new Guid("277c86ad-4b7f-4837-b226-78a13be39431"), "45 - 54 years old", 4 },
                    { new Guid("6b92403e-a419-4c68-8a3b-40a02432aca6"), "55 - 64 years old", 5 },
                    { new Guid("d3a2cac6-a637-4b45-8df3-c00091eb8a27"), "65+ years old", 6 }
                });

            migrationBuilder.InsertData(
                table: "ConfidenceGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("d76a0b09-88d0-4032-9ac0-d668b82daa52"), "No confidence", 1 },
                    { new Guid("42ad9a87-f2f9-491b-93fc-fab35438b061"), "Low confidence", 2 },
                    { new Guid("ada4ca24-0a83-4e5f-96c7-8d23dfc103f8"), "Moderate confidence", 3 },
                    { new Guid("7aa5e506-3045-4595-bf9b-1df1c2b56757"), "High confidence", 4 },
                    { new Guid("9e0df8c2-3399-4c93-8a38-fbbdcfdc6e46"), "Full confidence", 5 }
                });

            migrationBuilder.InsertData(
                table: "EducationGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("881af127-86e7-4355-b00d-92c59b1a0862"), "PhD", 6 },
                    { new Guid("49bd1de2-9a62-48ed-8467-c430afa8c786"), "Postgraduate Master", 5 },
                    { new Guid("c13030cf-9722-45c1-bc6d-ef2b955fb081"), "Bachelor degree or equivalent", 4 },
                    { new Guid("541c2d56-c0ed-4c5d-9b50-58e09cb15a36"), "Secondary Education", 2 },
                    { new Guid("44dd4b2b-d879-40b0-8e80-7665c95842b2"), "Primary Education", 1 },
                    { new Guid("23a1d819-1661-4df2-8f2a-a64f159ded27"), "Vocational training", 3 }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "Description", "IsCorrect", "ResponseOrder", "ScenarioId", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("5f04b997-3f68-4277-84be-5bf56ac904d0"), "Refer to colleague", null, 2, 3, "Ask her to contact one of your colleagues since you are on holiday.", 2 },
                    { new Guid("7d938139-4bbc-441e-976d-c34bfc51f638"), "Use the number to arrange a meeting", true, 4, 4, "Give the recruiter a call on one of the two numbers provided and arrange to meet up with him to discuss how he can help you.", 4 },
                    { new Guid("b8225bb8-f9c3-4a5c-b4e2-8cb7f4be85d2"), "Ignore and block", null, 3, 4, "Ignore the email and remove the recruiter from your LinkedIn.", 3 },
                    { new Guid("0de73aca-ac3e-4ecf-ab82-278f8d2f5ed0"), "Accept immediately and provide too much data", null, 2, 4, "You have been job hunting for ages and see this as a blessing in disguise. You reply to the email saying that you would appreciate his help and attach a copy of your CV, a copy of your ID and a link to your GitHub account. (Since you know he will most likely request all this information anyway.", 2 },
                    { new Guid("63610529-c4b7-4908-a8b4-8f4a6c2fa867"), "Click on the links and decide later", null, 1, 4, "Click on the links provided, and have a look at the company’s online profile as well as reviews left by others. If all seems good, get in contact with the recruiter.", 1 },
                    { new Guid("6601f635-7b60-433a-9294-ccc9db857035"), "Ask more questions and decide later", null, 4, 3, "Ask her a few complementary questions and based on her answers either provide her with your login details or don’t provide her with any information.", 4 },
                    { new Guid("ce72b336-d9d5-4721-9369-b09202f77e0c"), "Accept immediately", null, 3, 3, "Instantly provide her with your login details and wish her a merry Christmas.", 3 },
                    { new Guid("78ddae8c-8c83-4149-ba7b-dc9eac0553e5"), "Refuse immidately", true, 1, 3, "Refuse to help her entirely and hang up the phone.", 1 },
                    { new Guid("f3e7e3c7-0ebc-4407-b7ff-a529b2548c39"), "Ask more questions and decide later", null, 4, 1, "Ask her a few complementary questions and based on her answers either provide her with your login details or don’t provide her with any information.", 4 },
                    { new Guid("9661e31a-31e5-40e6-9e51-98c0c0a1b795"), "Ignore and block", null, 3, 2, "Ignore the email and remove the recruiter from your LinkedIn.", 3 },
                    { new Guid("f15aa414-1021-4d56-8c84-44cef168bd85"), "Accept immediately and provide too much data", null, 2, 2, "You have been job hunting for ages and see this as a blessing in disguise. You reply to the email saying that you would appreciate his help and attach a copy of your CV, a copy of your ID and a link to your GitHub account. (Since you know he will most likely request all this information anyway.", 2 },
                    { new Guid("dc890634-b9b2-4e7f-b85b-609051c98ecd"), "Click on the links and decide later", null, 1, 2, "Click on the links provided, and have a look at the company’s online profile as well as reviews left by others. If all seems good, get in contact with the recruiter.", 1 },
                    { new Guid("0f9766ed-8016-461e-a390-6da0e28cc3bd"), "Accept immediately", null, 3, 1, "Instantly provide her with your login details and wish her a merry Christmas.", 3 },
                    { new Guid("fe167d38-27ad-4696-9aa1-087694a129b1"), "Refer to colleague", null, 2, 1, "Ask her to contact one of your colleagues since you are on holiday.", 2 },
                    { new Guid("f4f231b9-8b23-4ca3-ae1e-b8d26f17ec8b"), "Refuse immidately", null, 1, 1, "Refuse to help her entirely and hang up the phone.", 1 },
                    { new Guid("d26b4582-47f7-44b6-9a4f-358460c791b7"), "Use the number to arrange a meeting", null, 4, 2, "Give the recruiter a call on one of the two numbers provided and arrange to meet up with him to discuss how he can help you.", 4 }
                });

            migrationBuilder.InsertData(
                table: "Scenarios",
                columns: new[] { "Id", "Context", "Feedback", "ScenarioId" },
                values: new object[,]
                {
                    { new Guid("25e9092d-7e51-4267-af3c-0d57e5e74c22"), "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is very sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what user-name you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?", null, 1 },
                    { new Guid("aef32a75-fe38-439f-b960-5f6939eb0010"), "You are a Computer Science Honours student at UCT, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have a big network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in Cape Town. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position as of yet post studies? I’d be keen to have a chat with you to find out what It is that really interests you so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?", null, 2 },
                    { new Guid("ed9dc442-8ea7-4783-be44-64fcc28d9653"), "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is very sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what user-name you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?", "Placeholder feedback 1", 3 },
                    { new Guid("d2cc2adc-4b57-4354-80c4-ead31a4b7e86"), "You are a Computer Science Honours student at UCT, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have a big network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in Cape Town. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position as of yet post studies? I’d be keen to have a chat with you to find out what It is that really interests you so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?", "Placeholder feedback 2", 4 }
                });

            migrationBuilder.InsertData(
                table: "YearGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("d50f023a-fe80-4895-a5c1-c061857aee25"), "4 - 5 years", 3 },
                    { new Guid("bd39355e-1e43-4d72-bc01-073f384a54af"), "1 year or less", 1 },
                    { new Guid("0ab4ff8c-c781-4ae7-a83c-83c451a28fcd"), "2 - 3 years", 2 },
                    { new Guid("d8a9ac87-74a4-4cf5-8a9e-1cff0af31978"), "6 years or more", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("13ae1545-c92f-4ba1-8c90-5327b1ee1cf7"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("277c86ad-4b7f-4837-b226-78a13be39431"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("6b92403e-a419-4c68-8a3b-40a02432aca6"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("75a66b53-e787-4f46-bab9-c2b3846402c0"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("a760b88e-2204-498b-82b2-23ac9911cf36"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("d3a2cac6-a637-4b45-8df3-c00091eb8a27"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("42ad9a87-f2f9-491b-93fc-fab35438b061"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("7aa5e506-3045-4595-bf9b-1df1c2b56757"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("9e0df8c2-3399-4c93-8a38-fbbdcfdc6e46"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("ada4ca24-0a83-4e5f-96c7-8d23dfc103f8"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("d76a0b09-88d0-4032-9ac0-d668b82daa52"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("23a1d819-1661-4df2-8f2a-a64f159ded27"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("44dd4b2b-d879-40b0-8e80-7665c95842b2"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("49bd1de2-9a62-48ed-8467-c430afa8c786"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("541c2d56-c0ed-4c5d-9b50-58e09cb15a36"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("881af127-86e7-4355-b00d-92c59b1a0862"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("c13030cf-9722-45c1-bc6d-ef2b955fb081"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("0de73aca-ac3e-4ecf-ab82-278f8d2f5ed0"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("0f9766ed-8016-461e-a390-6da0e28cc3bd"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("5f04b997-3f68-4277-84be-5bf56ac904d0"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("63610529-c4b7-4908-a8b4-8f4a6c2fa867"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("6601f635-7b60-433a-9294-ccc9db857035"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("78ddae8c-8c83-4149-ba7b-dc9eac0553e5"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("7d938139-4bbc-441e-976d-c34bfc51f638"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("9661e31a-31e5-40e6-9e51-98c0c0a1b795"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("b8225bb8-f9c3-4a5c-b4e2-8cb7f4be85d2"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("ce72b336-d9d5-4721-9369-b09202f77e0c"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("d26b4582-47f7-44b6-9a4f-358460c791b7"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("dc890634-b9b2-4e7f-b85b-609051c98ecd"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("f15aa414-1021-4d56-8c84-44cef168bd85"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("f3e7e3c7-0ebc-4407-b7ff-a529b2548c39"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("f4f231b9-8b23-4ca3-ae1e-b8d26f17ec8b"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("fe167d38-27ad-4696-9aa1-087694a129b1"));

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: new Guid("25e9092d-7e51-4267-af3c-0d57e5e74c22"));

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: new Guid("aef32a75-fe38-439f-b960-5f6939eb0010"));

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: new Guid("d2cc2adc-4b57-4354-80c4-ead31a4b7e86"));

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: new Guid("ed9dc442-8ea7-4783-be44-64fcc28d9653"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("0ab4ff8c-c781-4ae7-a83c-83c451a28fcd"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("bd39355e-1e43-4d72-bc01-073f384a54af"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("d50f023a-fe80-4895-a5c1-c061857aee25"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("d8a9ac87-74a4-4cf5-8a9e-1cff0af31978"));

            migrationBuilder.DropColumn(
                name: "Feedback",
                table: "Scenarios");

            migrationBuilder.DropColumn(
                name: "IsCorrect",
                table: "Responses");

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
                    { new Guid("b7a649a3-e69e-44a2-8a65-59002a08a353"), "PhD", 6 },
                    { new Guid("41f5050c-fadf-4610-a63f-7bf9c54675c0"), "Bachelor degree or equivalent", 4 },
                    { new Guid("0250f7c3-d991-4822-b532-6520d9182ed9"), "Postgraduate Master", 5 },
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
                    { new Guid("fb9aafc7-7a64-4468-84b2-3fc67a8a42ff"), "Ignore and block", 3, 2, "Ignore the email and remove the recruiter from your LinkedIn.", 3 },
                    { new Guid("1b4f2071-8461-4626-9ee2-3a86f869ac05"), "Click on the links and decide later", 1, 2, "Click on the links provided, and have a look at the company’s online profile as well as reviews left by others. If all seems good, get in contact with the recruiter.", 1 },
                    { new Guid("42e4ed4a-dad5-44ee-b126-5b1e833f35e6"), "Accept immediately and provide too much data", 2, 2, "You have been job hunting for ages and see this as a blessing in disguise. You reply to the email saying that you would appreciate his help and attach a copy of your CV, a copy of your ID and a link to your GitHub account. (Since you know he will most likely request all this information anyway.", 2 },
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
                table: "YearGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("f84e29fc-e245-4a2f-b52c-bc55e7545b6a"), "4 - 5 years", 3 },
                    { new Guid("34f965c4-c4d0-430c-9eff-d6af3fe838f5"), "1 year or less", 1 },
                    { new Guid("95f91fdc-84fb-4d04-81ac-681509581c5a"), "2 - 3 years", 2 },
                    { new Guid("78af586f-27a7-4ff4-a681-262c59beedf6"), "6 years or more", 4 }
                });
        }
    }
}
