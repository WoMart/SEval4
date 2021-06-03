using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SEval4.Migrations
{
    public partial class IsCorrect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScenariosSeenByParticipants");

            migrationBuilder.DeleteData(
                table: "StudyGroups",
                keyColumn: "Id",
                keyValue: new Guid("0b20770d-22bf-45b4-809c-7b8d0af79950"));

            migrationBuilder.DeleteData(
                table: "StudyGroups",
                keyColumn: "Id",
                keyValue: new Guid("4c1aa8a4-af70-41ee-9011-b2a72f9e380c"));

            migrationBuilder.AddColumn<bool>(
                name: "IsCorrect",
                table: "SurveyAnswers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "EvaluationScenarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Context",
                value: "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much-needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is deeply sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what username you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?");

            migrationBuilder.UpdateData(
                table: "EvaluationScenarios",
                keyColumn: "Id",
                keyValue: 3,
                column: "Context",
                value: "You are a Computer Science Honours student at University of Aberdeen, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have an extensive network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in UK. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position yet post studies? I would be keen to have a chat with you to find out what It is that really interests you, so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?");

            migrationBuilder.UpdateData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Context",
                value: "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much-needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is deeply sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what username you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?");

            migrationBuilder.UpdateData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: 3,
                column: "Context",
                value: "You are a Computer Science Honours student at University of Aberdeen, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have an extensive network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in UK. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position yet post studies? I would be keen to have a chat with you to find out what It is that really interests you, so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?");

            migrationBuilder.UpdateData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: 9,
                column: "Context",
                value: "You are sitting in one of the classes that you attend every week. Your lecturer walks into the class and introduces a guest lecturer to you from an external organisation. The guest lecturer provides a brief explanation about his organisation and that he is extremely grateful to be speaking directly to the students. The guest lecturer provides the students with a small assignment to perform. The guest lecturer informs the students that this assignment will count towards their marks for the end of the year. Upon receiving the assignment, you find that apart from requesting your student number, you are also requested to provide your date of birth as well as the last 4 digits of your identification document (ID) number. While you are considering whether you are going to provide this information, the guest lecturer assures you that this information will only be used for recruitment purposes later on. Which action do you take?");

            migrationBuilder.InsertData(
                table: "StudyGroups",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("e16d04f2-c703-473a-a820-785dbd277127"), "SEADM" },
                    { new Guid("07c9fc6a-6784-4102-8d9e-d391622497b2"), "Feedback" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudyGroups",
                keyColumn: "Id",
                keyValue: new Guid("07c9fc6a-6784-4102-8d9e-d391622497b2"));

            migrationBuilder.DeleteData(
                table: "StudyGroups",
                keyColumn: "Id",
                keyValue: new Guid("e16d04f2-c703-473a-a820-785dbd277127"));

            migrationBuilder.DropColumn(
                name: "IsCorrect",
                table: "SurveyAnswers");

            migrationBuilder.CreateTable(
                name: "ScenariosSeenByParticipants",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InSurvey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScenarioId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScenariosSeenByParticipants", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "EvaluationScenarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Context",
                value: "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is very sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what user-name you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?");

            migrationBuilder.UpdateData(
                table: "EvaluationScenarios",
                keyColumn: "Id",
                keyValue: 3,
                column: "Context",
                value: "You are a Computer Science Honours student at UCT, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have a big network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in Cape Town. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position as of yet post studies? I’d be keen to have a chat with you to find out what It is that really interests you so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?");

            migrationBuilder.UpdateData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "Context",
                value: "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is very sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what user-name you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?");

            migrationBuilder.UpdateData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: 3,
                column: "Context",
                value: "You are a Computer Science Honours student at UCT, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have a big network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in Cape Town. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position as of yet post studies? I’d be keen to have a chat with you to find out what It is that really interests you so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?");

            migrationBuilder.UpdateData(
                table: "Scenarios",
                keyColumn: "Id",
                keyValue: 9,
                column: "Context",
                value: "You are sitting in one of the classes that you attend every week. Your lecturer walks into the class and introduces a guest lecturer to you from an external organisation. The guest lecturer provides a brief explanation about his organisation and that he is extremely grateful to be speaking directly to the students. The guest lecturer provides the students with a small assignment to perform. The guest lecturer informs the students that this assignment will count towards their marks for the end of the year. Upon receiving the assignment, you find that apart from requesting your student number, you are also requested to provide your date of birth as well as the last 7 digits of your identification document (ID) number. While you are considering whether you are going to provide this information, the guest lecturer assures you that this information will only be used for recruitment purposes later on. Which action do you take?");

            migrationBuilder.InsertData(
                table: "StudyGroups",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4c1aa8a4-af70-41ee-9011-b2a72f9e380c"), "SEADM" },
                    { new Guid("0b20770d-22bf-45b4-809c-7b8d0af79950"), "Feedback" }
                });
        }
    }
}
