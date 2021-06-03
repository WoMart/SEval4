﻿using System;
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
                name: "EvaluationAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScenarioId = table.Column<int>(type: "int", nullable: false),
                    ResponseValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationAnswers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationResponses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScenarioId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluationResponses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EvaluationScenarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    Value = table.Column<int>(type: "int", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Scenarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Context = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scenarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScenariosSeenByParticipants",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InSurvey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScenarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScenariosSeenByParticipants", x => x.ID);
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsertTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScenarioId = table.Column<int>(type: "int", nullable: false),
                    ResponseValue = table.Column<int>(type: "int", nullable: false)
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
                    { 1, "No confidence" },
                    { 2, "Low confidence" },
                    { 3, "Moderate confidence" },
                    { 4, "High confidence" },
                    { 5, "Full confidence" }
                });

            migrationBuilder.InsertData(
                table: "EducationGroups",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { 6, "PhD" },
                    { 5, "Postgraduate Master" },
                    { 4, "Bachelor degree or equivalent" },
                    { 2, "Secondary Education" },
                    { 1, "Primary Education" },
                    { 3, "Vocational training" }
                });

            migrationBuilder.InsertData(
                table: "EvaluationResponses",
                columns: new[] { "Id", "Description", "IsCorrect", "ScenarioId", "Text", "Value" },
                values: new object[,]
                {
                    { 30, "Accept", false, 8, "Submit the assignment to the new link, without asking any questions.", 2 },
                    { 23, "Accept", false, 6, "Swipe the student in immediately, since you know how stressful it is submitting an assignment at the last minute and you know there is no time to waste.", 3 },
                    { 24, "Defer to reception", true, 6, "Give the student directions to the access control offices where the student can prove their identity and hopefully get access to a computer lab within 15 minutes to submit their assignment.", 4 },
                    { 25, "Accept and use his answers", false, 7, "You see this as a life saver and decide to use this to your advantage by comparing his answers to yours and using his answers to help you finish your assignment. You then also reply to his email telling him where your answers were different to his.", 1 },
                    { 26, "Reject but use his answers", false, 7, "You see this as a life saver and decide to use this to your advantage by comparing his answers to yours and using his answers to help you finish your assignment. You do not respond to his email, however, since you do not know him and would not want his answers to be identical to yours out of fear of being caught for plagiarism.", 2 },
                    { 27, "Reject and do not use his answers", true, 7, "You close the PDF immediately after opening it and delete it. You do not respond to the email and decide to complete your assignment on your own without comparing your answers to the answers sent to you by the student.", 3 },
                    { 28, "Reject but send him your answers", false, 7, "You are terribly busy finishing off your assignment and do not have time to look at his answers. You therefore decide to just send him your assignment so far and say he is welcome to compare answers, but you do not have time.", 4 },
                    { 29, "Reject", false, 8, "Deny the new submission link and use the old (original) submission link instead.", 1 },
                    { 31, "Confirm through 3rd party", true, 8, "You ask your friend whether they also received the email and based on your friend's answer decide where to submit your assignment.", 3 },
                    { 39, "Reject", true, 10, "I do not comply with his request at all.", 3 },
                    { 33, "Ask to elaborate and decide later", false, 9, "Ask the guest lecturer a few complementary questions and based on his answers decide whether to provide the information.", 1 },
                    { 34, "Defer to the lecturer", true, 9, "Ask the guest lecturer to contact your lecturer directly to obtain this information.", 2 },
                    { 35, "Reject", false, 9, "Do not provide the information and do not tell the guest lecturer where to get it as I deem it to be sensitive information.", 3 },
                    { 36, "Accept", false, 9, "Provide all the requested information.", 4 },
                    { 37, "Ask to elaborate and decide later", false, 10, "I ask several complementary questions before I comply by clicking the download link.", 1 },
                    { 38, "Ask to elaborate and request time to evaluate later", false, 10, "I ask complementary questions and ask if I can come back to him at a later stage.", 2 },
                    { 22, "Refuse", false, 6, "Refuse to help the student at all and tell them they should not have waited till the last minute to submit their assignment and they should always have their student card on them while on campus.", 2 },
                    { 40, "Accept", false, 10, "I instantly comply and follow the new download link.", 4 },
                    { 32, "Ask to elaborate and decide later", false, 8, "You reply to the lecturer's email asking a few complementary questions, before accepting the new link to be correct and submitting to it.", 4 },
                    { 21, "Ask to elaborate and decide later", false, 6, "Even though the student is stressed and needs to get into the lab as soon as possible, you decide to ask the student a few questions and based on his/her answers decide on whether to swipe them in or not.", 1 },
                    { 13, "Enter competition through official means", true, 4, "Record your video in a few days but decide to enter the competition yourself instead by going to the official festival website and entering the competition there, without sending the person on Facebook Messenger any of your details.", 1 },
                    { 19, "Scan for viruses and check the drive", false, 5, "You first scan the flash drive for viruses and if it is found to be virus free, start examining all folders and opening all files stored on the flash drive to hopefully identify the owner.", 3 },
                    { 1, "Accept instantly", false, 1, "Instantly provide her with your login details and wish her a merry Christmas.", 1 },
                    { 2, "Ask to elaborate and decide later", false, 1, "Ask her a few complementary questions and based on her answers either provide her with your login details or do not provide her with any information.", 2 },
                    { 3, "Reject", true, 1, "Refuse to help her entirely and hang up the phone.", 3 }
                });

            migrationBuilder.InsertData(
                table: "EvaluationResponses",
                columns: new[] { "Id", "Description", "IsCorrect", "ScenarioId", "Text", "Value" },
                values: new object[,]
                {
                    { 4, "Defer to colleague", false, 1, "Ask her to contact one of your colleagues since you are on holiday.", 4 },
                    { 5, "Ask to elaborate and decide later", false, 2, "Reply to the email, asking her a few complementary questions and based on her answers either provide her your preliminary time report or refuse to send it to her.", 1 },
                    { 6, "Validate through 3rd party", true, 2, "Contact your superior to find out whether they approve of you sending your preliminary time report to the person requesting it or not.", 2 },
                    { 7, "Refuse", false, 2, "Refuse to send her your preliminary time report.", 3 },
                    { 8, "Accept immediately", false, 2, "Since you do not have much work to do, you get working on your preliminary time report immediately and email it to the requester as soon as possible.", 4 },
                    { 20, "Leave the drive where it is", false, 5, "Leave the flash drive where it is, without plugging it into any computer or opening any of the files.", 4 },
                    { 9, "Validate through requester-provided links", false, 3, "Click on the links provided and have a look at the company's online profile as well as reviews left by others. If all seems good, contact the recruiter.", 1 },
                    { 11, "Give too much data", false, 3, "You have been job hunting for ages and see this as a blessing in disguise. You reply to the email saying that you would appreciate his help and attach a copy of your CV, a copy of your ID and a link to your GitHub account. (Since you know he will most likely request all this information anyway.", 3 },
                    { 12, "Reject", false, 3, "Ignore the email and remove the recruiter from your LinkedIn.", 4 },
                    { 14, "Accept", false, 4, "Record your video in a few days and send him your video along with all the information requested, since he only needs it to enter you into the competition.", 2 },
                    { 15, "Accept and change login details 24h later", false, 4, "Record your video in a few days and send him your video along with all the information requested, however you are a bit wary about giving out your Facebook login details and decide to change your Facebook password 24 hours after sending it to him.", 3 },
                    { 16, "Distrust the whole competition", false, 4, "Decide not to enter the competition at all. Since the person on Facebook was asking for your Facebook login details for the competition, you conclude that the entire competition must be fake and decide that it is best not to enter.", 4 },
                    { 17, "Ask a friend to check the drive", false, 5, "Give the flash drive to a friend and ask them to try identifying the owner by examining the files on their computer.", 1 },
                    { 18, "Check drive on virtual machine", true, 5, "You decide to install a virtual machine on your computer and use that virtual machine to examine all folders and open all files on the flash drive in an attempt to identify the owner.", 2 },
                    { 10, "Accept / Call the recruiter's nubmer and arrange a meeting", true, 3, "Give the recruiter a call on one of the two numbers provided and arrange a video call with him to discuss how he can help you.", 2 }
                });

            migrationBuilder.InsertData(
                table: "EvaluationScenarios",
                columns: new[] { "Id", "Context", "Feedback" },
                values: new object[,]
                {
                    { 4, "You receive a message on the Facebook Messenger app from someone who is not your friend on Facebook. The person who sent you the message, claims to be a marketing agent for a local festival. He tells you about a competition to win free tickets to the festival. You really wanted to attend this festival and the sound of winning free tickets gets you very excited, however you decide to have a look at the festival’s website, to confirm there is really a competition running. After having a look at the website, you see that there is really a competition running and that all you must do is submit a video of yourself showing how excited you are about the festival and showing off your festival dance moves. You decide to thank the person who sent you a message on Facebook Messenger, since you are grateful for finding out about this competition. The person responds saying that it is no problem at all, and he is happy to help. He goes on to ask if you would not mind him assisting you with your entry, because, he explains, that if he helps you, he will get commission. You are not all that technically savvy and you would not mind the help, so you respond saying thanking him for his offer and saying that you would really appreciate his help. He responds saying that it is no problem at all. He tells you that all you will need to do is send him your entry video via Facebook Messenger as well as your full name, date of birth and Facebook login details (email and password), since an entry into the competition requires a link to your Facebook account. Which action do you take?", "Placeholder feedback 2" },
                    { 3, "You are a Computer Science Honours student at UCT, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have a big network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in Cape Town. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position as of yet post studies? I’d be keen to have a chat with you to find out what It is that really interests you so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?", "Placeholder feedback 2" },
                    { 2, "You are sitting at your desk working. It is an ordinary Thursday in late September, and you do not really have all that much to do. You get an email, from a new email address, saying that a new person at your company’s external accounting firm has started to work on the time reports, and she needs your preliminary time report (a document detailing the number of hours you have worked) mailed to her email at the accounting firm as soon as possible, preferably today, as the end of the quarter is coming up and the owners have requested financial information as soon as possible. You do take note, however, that the email address which this email was sent from has the same domain as all other emails which you have received from the accounting firm in the past. In addition, the style of the email’s signature is the same as the style of the signatures of all previous emails received from various other people working at the accounting firm. Which action do you take?", "Placeholder feedback 2" },
                    { 1, "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is very sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what user-name you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?", "Placeholder feedback 1" }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "Description", "IsCorrect", "ScenarioId", "Text", "Value" },
                values: new object[,]
                {
                    { 23, "Accept", false, 6, "Swipe the student in immediately, since you know how stressful it is submitting an assignment at the last minute and you know there is no time to waste.", 3 },
                    { 24, "Defer to reception", true, 6, "Give the student directions to the access control offices where the student can prove their identity and hopefully get access to a computer lab within 15 minutes to submit their assignment.", 4 },
                    { 25, "Accept and use his answers", false, 7, "You see this as a life saver and decide to use this to your advantage by comparing his answers to yours and using his answers to help you finish your assignment. You then also reply to his email telling him where your answers were different to his.", 1 },
                    { 26, "Reject but use his answers", false, 7, "You see this as a life saver and decide to use this to your advantage by comparing his answers to yours and using his answers to help you finish your assignment. You do not respond to his email, however, since you do not know him and would not want his answers to be identical to yours out of fear of being caught for plagiarism.", 2 },
                    { 27, "Reject and do not use his answers", true, 7, "You close the PDF immediately after opening it and delete it. You do not respond to the email and decide to complete your assignment on your own without comparing your answers to the answers sent to you by the student.", 3 },
                    { 29, "Reject", false, 8, "Deny the new submission link and use the old (original) submission link instead.", 1 },
                    { 30, "Accept", false, 8, "Submit the assignment to the new link, without asking any questions.", 2 },
                    { 31, "Confirm through 3rd party", true, 8, "You ask your friend whether they also received the email and based on your friend's answer decide where to submit your assignment.", 3 },
                    { 32, "Ask to elaborate and decide later", false, 8, "You reply to the lecturer's email asking a few complementary questions, before accepting the new link to be correct and submitting to it.", 4 },
                    { 33, "Ask to elaborate and decide later", false, 9, "Ask the guest lecturer a few complementary questions and based on his answers decide whether to provide the information.", 1 },
                    { 34, "Defer to the lecturer", true, 9, "Ask the guest lecturer to contact your lecturer directly to obtain this information.", 2 },
                    { 35, "Reject", false, 9, "Do not provide the information and do not tell the guest lecturer where to get it as I deem it to be sensitive information.", 3 },
                    { 36, "Accept", false, 9, "Provide all the requested information.", 4 },
                    { 37, "Ask to elaborate and decide later", false, 10, "I ask several complementary questions before I comply by clicking the download link.", 1 },
                    { 38, "Ask to elaborate and request time to evaluate later", false, 10, "I ask complementary questions and ask if I can come back to him at a later stage.", 2 },
                    { 39, "Reject", true, 10, "I do not comply with his request at all.", 3 },
                    { 40, "Accept", false, 10, "I instantly comply and follow the new download link.", 4 },
                    { 22, "Refuse", false, 6, "Refuse to help the student at all and tell them they should not have waited till the last minute to submit their assignment and they should always have their student card on them while on campus.", 2 },
                    { 21, "Ask to elaborate and decide later", false, 6, "Even though the student is stressed and needs to get into the lab as soon as possible, you decide to ask the student a few questions and based on his/her answers decide on whether to swipe them in or not.", 1 },
                    { 28, "Reject but send him your answers", false, 7, "You are terribly busy finishing off your assignment and do not have time to look at his answers. You therefore decide to just send him your assignment so far and say he is welcome to compare answers, but you do not have time.", 4 },
                    { 19, "Scan for viruses and check the drive", false, 5, "You first scan the flash drive for viruses and if it is found to be virus free, start examining all folders and opening all files stored on the flash drive to hopefully identify the owner.", 3 },
                    { 1, "Accept instantly", false, 1, "Instantly provide her with your login details and wish her a merry Christmas.", 1 },
                    { 2, "Ask to elaborate and decide later", false, 1, "Ask her a few complementary questions and based on her answers either provide her with your login details or do not provide her with any information.", 2 }
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Id", "Description", "IsCorrect", "ScenarioId", "Text", "Value" },
                values: new object[,]
                {
                    { 20, "Leave the drive where it is", false, 5, "Leave the flash drive where it is, without plugging it into any computer or opening any of the files.", 4 },
                    { 4, "Defer to colleague", false, 1, "Ask her to contact one of your colleagues since you are on holiday.", 4 },
                    { 5, "Ask to elaborate and decide later", false, 2, "Reply to the email, asking her a few complementary questions and based on her answers either provide her your preliminary time report or refuse to send it to her.", 1 },
                    { 6, "Validate through 3rd party", true, 2, "Contact your superior to find out whether they approve of you sending your preliminary time report to the person requesting it or not.", 2 },
                    { 7, "Refuse", false, 2, "Refuse to send her your preliminary time report.", 3 },
                    { 8, "Accept immediately", false, 2, "Since you do not have much work to do, you get working on your preliminary time report immediately and email it to the requester as soon as possible.", 4 },
                    { 9, "Validate through requester-provided links", false, 3, "Click on the links provided and have a look at the company's online profile as well as reviews left by others. If all seems good, contact the recruiter.", 1 },
                    { 3, "Reject", true, 1, "Refuse to help her entirely and hang up the phone.", 3 },
                    { 11, "Give too much data", false, 3, "You have been job hunting for ages and see this as a blessing in disguise. You reply to the email saying that you would appreciate his help and attach a copy of your CV, a copy of your ID and a link to your GitHub account. (Since you know he will most likely request all this information anyway.", 3 },
                    { 12, "Reject", false, 3, "Ignore the email and remove the recruiter from your LinkedIn.", 4 },
                    { 13, "Enter competition through official means", true, 4, "Record your video in a few days but decide to enter the competition yourself instead by going to the official festival website and entering the competition there, without sending the person on Facebook Messenger any of your details.", 1 },
                    { 14, "Accept", false, 4, "Record your video in a few days and send him your video along with all the information requested, since he only needs it to enter you into the competition.", 2 },
                    { 15, "Accept and change login details 24h later", false, 4, "Record your video in a few days and send him your video along with all the information requested, however you are a bit wary about giving out your Facebook login details and decide to change your Facebook password 24 hours after sending it to him.", 3 },
                    { 16, "Distrust the whole competition", false, 4, "Decide not to enter the competition at all. Since the person on Facebook was asking for your Facebook login details for the competition, you conclude that the entire competition must be fake and decide that it is best not to enter.", 4 },
                    { 17, "Ask a friend to check the drive", false, 5, "Give the flash drive to a friend and ask them to try identifying the owner by examining the files on their computer.", 1 },
                    { 18, "Check drive on virtual machine", true, 5, "You decide to install a virtual machine on your computer and use that virtual machine to examine all folders and open all files on the flash drive in an attempt to identify the owner.", 2 },
                    { 10, "Accept / Call the recruiter's nubmer and arrange a meeting", true, 3, "Give the recruiter a call on one of the two numbers provided and arrange a video call with him to discuss how he can help you.", 2 }
                });

            migrationBuilder.InsertData(
                table: "Scenarios",
                columns: new[] { "Id", "Context" },
                values: new object[,]
                {
                    { 10, "You have been working on a major project for a customer for a long time. The project has been quite stressful in periods, and calmer in others. It has been a rewarding project, and you think it is a little sad that it is soon to end. The project has involved a number of offices in several countries, as well as many people. The project also uses special software, especially developed for this project. You do not know that much about how it works, as you have mostly been involved at an overall level. At the moment you are sitting trying to finish the last of this week's documentation in order to leave for the weekend. You get a call from a 'Jacob', from technical support, which is stationed in San Francisco. He explains that you seem to be running a previous version of the software, something that has given them severe problems as it hinders the encryption from working correctly, because it uses another system for the public keys. Jacob directs you to a link where a more recent version can be found and asks you to install it as soon as possible and to log in again to stop the problems." },
                    { 9, "You are sitting in one of the classes that you attend every week. Your lecturer walks into the class and introduces a guest lecturer to you from an external organisation. The guest lecturer provides a brief explanation about his organisation and that he is extremely grateful to be speaking directly to the students. The guest lecturer provides the students with a small assignment to perform. The guest lecturer informs the students that this assignment will count towards their marks for the end of the year. Upon receiving the assignment, you find that apart from requesting your student number, you are also requested to provide your date of birth as well as the last 7 digits of your identification document (ID) number. While you are considering whether you are going to provide this information, the guest lecturer assures you that this information will only be used for recruitment purposes later on. Which action do you take?" },
                    { 8, "You are busy working in the computer labs on an important assignment that must be handed in within the next 30 minutes. You also have another application open which is monitoring your incoming emails. You receive an email from your lecturer who has given you the assignment and the email is related to the assignment which you are busy with. The email provides you with a different submission link than the one you originally had for submitting the assignment. You are fairly sure that this email is from this lecturer, however it is extremely uncommon for this lecturer to send out emails directly to the students. Communication such as this one is normally communicated via the announcement system on the course’s Blackboard page. Which action do you take?" },
                    { 7, "A day before an assignment is due you receive an email from a fellow student. You have never met this student before, but in the email the student says he is in the same class as you and that he got your email address from the participants section on the course’s Blackboard tab. Attached to the email is a PDF of that student’s assignment. The student says that he is not sure if his answers are correct, and he would really appreciate your help. He asks you to please read through his assignment, compare his answers to yours and then let him know if there are any differences. You open the attached PDF and can clearly see that the student has done the assignment. Which action do you take?" },
                    { 6, "Whilst walking towards the entrance turnstile at the computer lab, a person whom you have never met or seen before approaches you. This person is about the same age as you and looks like a fellow student. The person tells you that he has forgotten his student card at home and can now not enter through the turnstile to use the computers in the lab. The person asks if you could assist him with entering through the turnstile by allowing him to swipe in using your student card. Your card allows you to both swipe in and enter the computer lab. The person looks incredibly stressed and tells you he has an assignment due in 15 minutes that he needs to get access to a computer to submit. You know that there are policies in place that disallow swiping in other students to labs, however it will not harm you in any way to swipe in a fellow student and you could help him pass the course by helping him get to a computer to submit his assignment on time. Which action do you take?" },
                    { 4, "You receive a message on the Facebook Messenger app from someone who is not your friend on Facebook. The person who sent you the message, claims to be a marketing agent for a local festival. He tells you about a competition to win free tickets to the festival. You really wanted to attend this festival and the sound of winning free tickets gets you very excited, however you decide to have a look at the festival’s website, to confirm there is really a competition running. After having a look at the website, you see that there is really a competition running and that all you must do is submit a video of yourself showing how excited you are about the festival and showing off your festival dance moves. You decide to thank the person who sent you a message on Facebook Messenger, since you are grateful for finding out about this competition. The person responds saying that it is no problem at all, and he is happy to help. He goes on to ask if you would not mind him assisting you with your entry, because, he explains, that if he helps you, he will get commission. You are not all that technically savvy and you would not mind the help, so you respond saying thanking him for his offer and saying that you would really appreciate his help. He responds saying that it is no problem at all. He tells you that all you will need to do is send him your entry video via Facebook Messenger as well as your full name, date of birth and Facebook login details (email and password), since an entry into the competition requires a link to your Facebook account. Which action do you take?" },
                    { 3, "You are a Computer Science Honours student at UCT, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have a big network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in Cape Town. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position as of yet post studies? I’d be keen to have a chat with you to find out what It is that really interests you so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?" },
                    { 2, "You are sitting at your desk working. It is an ordinary Thursday in late September, and you do not really have all that much to do. You get an email, from a new email address, saying that a new person at your company’s external accounting firm has started to work on the time reports, and she needs your preliminary time report (a document detailing the number of hours you have worked) mailed to her email at the accounting firm as soon as possible, preferably today, as the end of the quarter is coming up and the owners have requested financial information as soon as possible. You do take note, however, that the email address which this email was sent from has the same domain as all other emails which you have received from the accounting firm in the past. In addition, the style of the email’s signature is the same as the style of the signatures of all previous emails received from various other people working at the accounting firm. Which action do you take?" },
                    { 1, "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is very sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what user-name you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?" },
                    { 5, "Whilst walking on campus you see a flash drive lying on the ground. You pick up the flash drive and notice that there are no identifiable traits on the outer shell of the flash drive that can be used to identify the owner. As you have lost several flash drives before, you feel sorry for the owner of this flash drive. You are aware of how much work could potentially be lost that may be saved on the flash drive. Which action do you take?" }
                });

            migrationBuilder.InsertData(
                table: "StudyGroups",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4c1aa8a4-af70-41ee-9011-b2a72f9e380c"), "SEADM" },
                    { new Guid("0b20770d-22bf-45b4-809c-7b8d0af79950"), "Feedback" }
                });

            migrationBuilder.InsertData(
                table: "YearGroups",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { 3, "4 - 5 years" },
                    { 1, "1 year or less" },
                    { 2, "2 - 3 years" },
                    { 4, "6 years or more" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttemptCounts_UserId",
                table: "AttemptCounts",
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
                name: "ScenariosSeenByParticipants");

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