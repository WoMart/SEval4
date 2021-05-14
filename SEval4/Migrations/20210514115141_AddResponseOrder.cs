using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SEval4.Migrations
{
    public partial class AddResponseOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("18a718de-8bc3-450e-a3ad-80c3d19f4f15"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("4d3e20e8-8eb9-4ace-9e5a-37c43b57ed7b"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("8ad345a8-51aa-40a0-b163-dadee4723459"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("deadec40-1e47-413b-b3a5-c3b4f4565437"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("ecd07c27-72c7-497e-a4e5-7aa4091e0626"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("f650bd91-732b-4ccf-a3b5-fb6007a881c6"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("32902ec6-ab46-4493-ab5e-4f9c9e398755"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("67959e9f-b101-4d81-8550-09c231e611fd"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("a487303b-0a2e-40ed-9c61-f348b0f4ec98"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("ab07ff7f-dbdd-439d-9bb1-f65ac6276722"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("da21c479-e8f2-4834-9c36-3c42ba1e28a0"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("0aff4eaf-8097-4f74-b6d7-fbf165392715"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("2fc9d1df-03c2-418d-840b-2a3a8adb4498"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("4ccd83af-27b9-4e0c-a9eb-f9c577dff120"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("63f1051f-99df-4f14-bc79-9372cd796ce6"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("6b15284e-3528-417e-a02e-9e9442abba64"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("998ad9f9-426a-4ca4-9c06-9847eeff96a5"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("5190393e-dc47-46e0-a646-27975103157a"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("64ef3932-8e78-462a-859c-d3ab97d22f7e"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("666526e5-ef2d-43ff-b6ad-c7cb8ffc7471"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("6966269c-93fa-4d67-81c1-a4a2cc3ee147"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("70c3ce1a-9871-4881-bec9-bd8838444d0f"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("916b51a8-dbaa-45c0-bdfb-cc3cde881552"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("be666461-9699-43f1-a764-0894ebb6f1d6"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("fa6c2e66-7b9f-455b-8dfa-3fe8c7966fdf"));

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: new Guid("79a40d0f-bcae-4f81-bcef-1163a516e8cf"));

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: new Guid("c0fe86b4-3277-4908-96e2-e730ac219445"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("1ebcb0b5-e899-4163-85db-e15566d4e894"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("9c230095-744e-4ee0-a432-e3d1525c9fba"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("9fae0962-bec3-404e-ae9b-f2ce28190218"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("ad607bb4-ee8a-48af-9f48-eebd41ac517a"));

            migrationBuilder.AddColumn<int>(
                name: "ResponseOrder",
                table: "Responses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AgeGroup",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("9e3417f4-e671-40b9-b8f1-b7b1c60ac07a"), "18 - 24 years old", 1 },
                    { new Guid("6b31aca0-fc91-426f-8de2-6fa2d6349b32"), "25 - 34 years old", 2 },
                    { new Guid("a4794276-6015-40c8-8a48-36a24842deec"), "35 - 44 years old", 3 },
                    { new Guid("2e145ff7-3349-485e-9669-78e95639ffc8"), "45 - 54 years old", 4 },
                    { new Guid("61a1a65c-5695-48d0-8bfd-93fe3cf8e701"), "55 - 64 years old", 5 },
                    { new Guid("8c3871e0-3724-42b4-bee9-f793eb52fd94"), "65+ years old", 6 }
                });

            migrationBuilder.InsertData(
                table: "ConfidenceGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("d6c17091-7b6b-4510-8aa2-a2df46a7003c"), "No confidence", 1 },
                    { new Guid("a2892204-9c9a-40a6-8f93-904462ca3ab6"), "Low confidence", 2 },
                    { new Guid("3203264a-f9b0-4fe9-a9ed-e9ee2dee299d"), "Moderate confidence", 3 },
                    { new Guid("3c3cead2-61f7-4a0e-9392-c35c804d8115"), "High confidence", 4 },
                    { new Guid("b786c2e6-14f4-4964-adca-912f43d112b8"), "Full confidence", 5 }
                });

            migrationBuilder.InsertData(
                table: "EducationGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("ee937ddb-b02b-4da8-9d5e-d38f2568ee88"), "PhD", 6 },
                    { new Guid("b012b592-55b9-4e17-aebf-6152be3f9bd4"), "Bachelor degree or equivalent", 4 },
                    { new Guid("31d91769-c2bd-468d-844b-7dc37f51137c"), "Postgraduate Master", 5 },
                    { new Guid("576c672a-547b-4944-882c-34808c3e98dc"), "Secondary Education", 2 },
                    { new Guid("721e0b79-04a2-4da6-9df3-bbe213840f79"), "Primary Education", 1 },
                    { new Guid("7680065f-5f93-49d7-825d-e08cd01b7131"), "Vocational training", 3 }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "Description", "ResponseOrder", "ScenarioId", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("dd67cea9-7104-478a-bcc9-62be3fef9442"), "Use the number to arrange a meeting", 4, 2, "Give the recruiter a call on one of the two numbers provided and arrange to meet up with him to discuss how he can help you.", 4 },
                    { new Guid("3811a777-c23c-4304-8c22-b1a1273c24b3"), "Ignore and block", 3, 2, "Ignore the email and remove the recruiter from your LinkedIn.", 3 },
                    { new Guid("663364e5-087b-47e9-a0c2-b43695905e05"), "Click on the links and decide later", 1, 2, "Click on the links provided, and have a look at the company’s online profile as well as reviews left by others. If all seems good, get in contact with the recruiter.", 1 },
                    { new Guid("5235d272-8e85-4865-a6c5-2ba52e128c84"), "Accept immediately and provide too much data", 2, 2, "You have been job hunting for ages and see this as a blessing in disguise. You reply to the email saying that you would appreciate his help and attach a copy of your CV, a copy of your ID and a link to your GitHub account. (Since you know he will most likely request all this information anyway.", 2 },
                    { new Guid("e32b2a67-d98d-4e48-bf4e-db88615ee8e0"), "Accept immediately", 3, 1, "Instantly provide her with your login details and wish her a merry Christmas.", 3 },
                    { new Guid("4ffe6b71-fd44-472e-becc-8e566fe6fc73"), "Refer to colleague", 2, 1, "Ask her to contact one of your colleagues since you are on holiday.", 2 },
                    { new Guid("e8d67f8f-32c8-4a65-823a-dfc39df85121"), "Refuse immidately", 1, 1, "Refuse to help her entirely and hang up the phone.", 1 },
                    { new Guid("3f5126a2-c6ad-4824-91e5-6f3066fd5180"), "Ask more questions and decide later", 4, 1, "Ask her a few complementary questions and based on her answers either provide her with your login details or don’t provide her with any information.", 4 }
                });

            migrationBuilder.InsertData(
                table: "Scenarios",
                columns: new[] { "Id", "Context", "Correct", "ScenarioId" },
                values: new object[,]
                {
                    { new Guid("9bb47c5b-cf33-40b1-80cd-a6fb6fb67962"), "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is very sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what user-name you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?", new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { new Guid("10c726e7-8677-45dd-868d-489f900b5cb8"), "You are a Computer Science Honours student at UCT, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have a big network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in Cape Town. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position as of yet post studies? I’d be keen to have a chat with you to find out what It is that really interests you so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?", new Guid("00000000-0000-0000-0000-000000000000"), 2 }
                });

            migrationBuilder.InsertData(
                table: "YearGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("b40de01e-7a7f-4a43-9d8a-d614b86687e9"), "4 - 5 years", 3 },
                    { new Guid("4cc57f90-3d10-4b21-9997-326992066c6c"), "1 year or less", 1 },
                    { new Guid("e5f52587-855e-44e5-acfe-4d68365905bd"), "2 - 3 years", 2 },
                    { new Guid("e914edb2-db5e-477d-a53e-392573c139b5"), "6 years or more", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("2e145ff7-3349-485e-9669-78e95639ffc8"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("61a1a65c-5695-48d0-8bfd-93fe3cf8e701"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("6b31aca0-fc91-426f-8de2-6fa2d6349b32"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("8c3871e0-3724-42b4-bee9-f793eb52fd94"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("9e3417f4-e671-40b9-b8f1-b7b1c60ac07a"));

            migrationBuilder.DeleteData(
                table: "AgeGroup",
                keyColumn: "Id",
                keyValue: new Guid("a4794276-6015-40c8-8a48-36a24842deec"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("3203264a-f9b0-4fe9-a9ed-e9ee2dee299d"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("3c3cead2-61f7-4a0e-9392-c35c804d8115"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("a2892204-9c9a-40a6-8f93-904462ca3ab6"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("b786c2e6-14f4-4964-adca-912f43d112b8"));

            migrationBuilder.DeleteData(
                table: "ConfidenceGroups",
                keyColumn: "Id",
                keyValue: new Guid("d6c17091-7b6b-4510-8aa2-a2df46a7003c"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("31d91769-c2bd-468d-844b-7dc37f51137c"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("576c672a-547b-4944-882c-34808c3e98dc"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("721e0b79-04a2-4da6-9df3-bbe213840f79"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("7680065f-5f93-49d7-825d-e08cd01b7131"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("b012b592-55b9-4e17-aebf-6152be3f9bd4"));

            migrationBuilder.DeleteData(
                table: "EducationGroups",
                keyColumn: "Id",
                keyValue: new Guid("ee937ddb-b02b-4da8-9d5e-d38f2568ee88"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("3811a777-c23c-4304-8c22-b1a1273c24b3"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("3f5126a2-c6ad-4824-91e5-6f3066fd5180"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("4ffe6b71-fd44-472e-becc-8e566fe6fc73"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("5235d272-8e85-4865-a6c5-2ba52e128c84"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("663364e5-087b-47e9-a0c2-b43695905e05"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("dd67cea9-7104-478a-bcc9-62be3fef9442"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("e32b2a67-d98d-4e48-bf4e-db88615ee8e0"));

            migrationBuilder.DeleteData(
                table: "Responses",
                keyColumn: "Id",
                keyValue: new Guid("e8d67f8f-32c8-4a65-823a-dfc39df85121"));

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: new Guid("10c726e7-8677-45dd-868d-489f900b5cb8"));

            migrationBuilder.DeleteData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: new Guid("9bb47c5b-cf33-40b1-80cd-a6fb6fb67962"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("4cc57f90-3d10-4b21-9997-326992066c6c"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("b40de01e-7a7f-4a43-9d8a-d614b86687e9"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("e5f52587-855e-44e5-acfe-4d68365905bd"));

            migrationBuilder.DeleteData(
                table: "YearGroups",
                keyColumn: "Id",
                keyValue: new Guid("e914edb2-db5e-477d-a53e-392573c139b5"));

            migrationBuilder.DropColumn(
                name: "ResponseOrder",
                table: "Responses");

            migrationBuilder.InsertData(
                table: "AgeGroup",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("deadec40-1e47-413b-b3a5-c3b4f4565437"), "18 - 24 years old", 1 },
                    { new Guid("4d3e20e8-8eb9-4ace-9e5a-37c43b57ed7b"), "25 - 34 years old", 2 },
                    { new Guid("f650bd91-732b-4ccf-a3b5-fb6007a881c6"), "35 - 44 years old", 3 },
                    { new Guid("ecd07c27-72c7-497e-a4e5-7aa4091e0626"), "45 - 54 years old", 4 },
                    { new Guid("8ad345a8-51aa-40a0-b163-dadee4723459"), "55 - 64 years old", 5 },
                    { new Guid("18a718de-8bc3-450e-a3ad-80c3d19f4f15"), "65+ years old", 6 }
                });

            migrationBuilder.InsertData(
                table: "ConfidenceGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("32902ec6-ab46-4493-ab5e-4f9c9e398755"), "No confidence", 1 },
                    { new Guid("a487303b-0a2e-40ed-9c61-f348b0f4ec98"), "Low confidence", 2 },
                    { new Guid("da21c479-e8f2-4834-9c36-3c42ba1e28a0"), "Moderate confidence", 3 },
                    { new Guid("ab07ff7f-dbdd-439d-9bb1-f65ac6276722"), "High confidence", 4 },
                    { new Guid("67959e9f-b101-4d81-8550-09c231e611fd"), "Full confidence", 5 }
                });

            migrationBuilder.InsertData(
                table: "EducationGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("998ad9f9-426a-4ca4-9c06-9847eeff96a5"), "PhD", 6 },
                    { new Guid("4ccd83af-27b9-4e0c-a9eb-f9c577dff120"), "Bachelor degree or equivalent", 4 },
                    { new Guid("2fc9d1df-03c2-418d-840b-2a3a8adb4498"), "Postgraduate Master", 5 },
                    { new Guid("63f1051f-99df-4f14-bc79-9372cd796ce6"), "Secondary Education", 2 },
                    { new Guid("0aff4eaf-8097-4f74-b6d7-fbf165392715"), "Primary Education", 1 },
                    { new Guid("6b15284e-3528-417e-a02e-9e9442abba64"), "Vocational training", 3 }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "Description", "ScenarioId", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("666526e5-ef2d-43ff-b6ad-c7cb8ffc7471"), "Use the number to arrange a meeting", 2, "Give the recruiter a call on one of the two numbers provided and arrange to meet up with him to discuss how he can help you.", 4 },
                    { new Guid("64ef3932-8e78-462a-859c-d3ab97d22f7e"), "Ignore and block", 2, "Ignore the email and remove the recruiter from your LinkedIn.", 3 },
                    { new Guid("5190393e-dc47-46e0-a646-27975103157a"), "Click on the links and decide later", 2, "Click on the links provided, and have a look at the company’s online profile as well as reviews left by others. If all seems good, get in contact with the recruiter.", 1 },
                    { new Guid("6966269c-93fa-4d67-81c1-a4a2cc3ee147"), "Accept immediately and provide too much data", 2, "You have been job hunting for ages and see this as a blessing in disguise. You reply to the email saying that you would appreciate his help and attach a copy of your CV, a copy of your ID and a link to your GitHub account. (Since you know he will most likely request all this information anyway.", 2 },
                    { new Guid("fa6c2e66-7b9f-455b-8dfa-3fe8c7966fdf"), "Accept immediately", 1, "Instantly provide her with your login details and wish her a merry Christmas.", 3 },
                    { new Guid("70c3ce1a-9871-4881-bec9-bd8838444d0f"), "Refer to colleague", 1, "Ask her to contact one of your colleagues since you are on holiday.", 2 },
                    { new Guid("916b51a8-dbaa-45c0-bdfb-cc3cde881552"), "Refuse immidately", 1, "Refuse to help her entirely and hang up the phone.", 1 },
                    { new Guid("be666461-9699-43f1-a764-0894ebb6f1d6"), "Ask more questions and decide later", 1, "Ask her a few complementary questions and based on her answers either provide her with your login details or don’t provide her with any information.", 4 }
                });

            migrationBuilder.InsertData(
                table: "Scenarios",
                columns: new[] { "Id", "Context", "Correct", "ScenarioId" },
                values: new object[,]
                {
                    { new Guid("c0fe86b4-3277-4908-96e2-e730ac219445"), "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is very sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what user-name you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?", new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { new Guid("79a40d0f-bcae-4f81-bcef-1163a516e8cf"), "You are a Computer Science Honours student at UCT, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have a big network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in Cape Town. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position as of yet post studies? I’d be keen to have a chat with you to find out what It is that really interests you so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?", new Guid("00000000-0000-0000-0000-000000000000"), 2 }
                });

            migrationBuilder.InsertData(
                table: "YearGroups",
                columns: new[] { "Id", "Text", "Value" },
                values: new object[,]
                {
                    { new Guid("9fae0962-bec3-404e-ae9b-f2ce28190218"), "4 - 5 years", 3 },
                    { new Guid("1ebcb0b5-e899-4163-85db-e15566d4e894"), "1 year or less", 1 },
                    { new Guid("ad607bb4-ee8a-48af-9f48-eebd41ac517a"), "2 - 3 years", 2 },
                    { new Guid("9c230095-744e-4ee0-a432-e3d1525c9fba"), "6 years or more", 4 }
                });
        }
    }
}
