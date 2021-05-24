﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SEval4.Data;

namespace SEval4.Migrations
{
    [DbContext(typeof(SEvalDBContext))]
    partial class SEvalDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SEval4.Models.AgeGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AgeGroup");

                    b.HasData(
                        new
                        {
                            Id = new Guid("216fb66e-3f48-4675-b25a-db5041ad6573"),
                            Text = "18 - 24 years old",
                            Value = 1
                        },
                        new
                        {
                            Id = new Guid("5e2dceef-778b-4dc8-9c11-f82757bea4e2"),
                            Text = "25 - 34 years old",
                            Value = 2
                        },
                        new
                        {
                            Id = new Guid("740e6fbc-efca-494c-9bca-f0f8c766e512"),
                            Text = "35 - 44 years old",
                            Value = 3
                        },
                        new
                        {
                            Id = new Guid("edbf43e5-f414-442a-a8d0-d308f61666e1"),
                            Text = "45 - 54 years old",
                            Value = 4
                        },
                        new
                        {
                            Id = new Guid("ed74e282-cc56-47f8-af48-797917e1b4a2"),
                            Text = "55 - 64 years old",
                            Value = 5
                        },
                        new
                        {
                            Id = new Guid("696db28c-248a-433c-b179-f5ba3b839ef4"),
                            Text = "65+ years old",
                            Value = 6
                        });
                });

            modelBuilder.Entity("SEval4.Models.AnswerBaseline", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ScenarioId")
                        .HasColumnType("int");

                    b.Property<Guid>("UserGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AnswersBaseline");
                });

            modelBuilder.Entity("SEval4.Models.ConfidenceGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ConfidenceGroups");

                    b.HasData(
                        new
                        {
                            Id = new Guid("618a8be4-ad9b-4645-8d92-bba91c5ebdb6"),
                            Text = "No confidence",
                            Value = 1
                        },
                        new
                        {
                            Id = new Guid("24af49f0-53fb-4706-bd70-7097d1494ed5"),
                            Text = "Low confidence",
                            Value = 2
                        },
                        new
                        {
                            Id = new Guid("f4c9280a-5f34-48e2-9e87-c23ffd49314f"),
                            Text = "Moderate confidence",
                            Value = 3
                        },
                        new
                        {
                            Id = new Guid("bf63e84f-bd12-45ec-afdc-e0be865f5393"),
                            Text = "High confidence",
                            Value = 4
                        },
                        new
                        {
                            Id = new Guid("768939be-4969-4d04-a662-9057e078b4a7"),
                            Text = "Full confidence",
                            Value = 5
                        });
                });

            modelBuilder.Entity("SEval4.Models.EducationGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EducationGroups");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ad50ccda-48e7-421e-93e8-d9d26b5742d3"),
                            Text = "Primary Education",
                            Value = 1
                        },
                        new
                        {
                            Id = new Guid("9711a7ad-e2e9-413e-b2d8-d7056d4cc96b"),
                            Text = "Secondary Education",
                            Value = 2
                        },
                        new
                        {
                            Id = new Guid("a8e1b6e8-4dd3-42b3-8c5c-1a466e2b1841"),
                            Text = "Vocational training",
                            Value = 3
                        },
                        new
                        {
                            Id = new Guid("da07da31-bec6-4681-87a7-92676bd2b77b"),
                            Text = "Bachelor degree or equivalent",
                            Value = 4
                        },
                        new
                        {
                            Id = new Guid("f6c6c9f7-8159-43d2-bd5b-d92ba149fa90"),
                            Text = "Postgraduate Master",
                            Value = 5
                        },
                        new
                        {
                            Id = new Guid("6a8cde70-a11e-4f59-bd66-4b9f434d0c61"),
                            Text = "PhD",
                            Value = 6
                        });
                });

            modelBuilder.Entity("SEval4.Models.EvalResponse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<int>("ResponseOrder")
                        .HasColumnType("int");

                    b.Property<int>("ScenarioId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EvaluationResponses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9d199788-2c8b-4327-b14a-58fb85f0eab5"),
                            Description = "Refuse immidately",
                            IsCorrect = true,
                            ResponseOrder = 1,
                            ScenarioId = 3,
                            Text = "Refuse to help her entirely and hang up the phone.",
                            Value = 1
                        },
                        new
                        {
                            Id = new Guid("94fc6f95-30cf-4f2a-8dce-b7c2458175f2"),
                            Description = "Refer to colleague",
                            IsCorrect = false,
                            ResponseOrder = 2,
                            ScenarioId = 3,
                            Text = "Ask her to contact one of your colleagues since you are on holiday.",
                            Value = 2
                        },
                        new
                        {
                            Id = new Guid("61f5b1ea-b92c-4f4b-befc-c142591eb9d1"),
                            Description = "Accept immediately",
                            IsCorrect = false,
                            ResponseOrder = 3,
                            ScenarioId = 3,
                            Text = "Instantly provide her with your login details and wish her a merry Christmas.",
                            Value = 3
                        },
                        new
                        {
                            Id = new Guid("b22cae60-5f03-414a-b865-968befbb22c3"),
                            Description = "Ask more questions and decide later",
                            IsCorrect = false,
                            ResponseOrder = 4,
                            ScenarioId = 3,
                            Text = "Ask her a few complementary questions and based on her answers either provide her with your login details or don’t provide her with any information.",
                            Value = 4
                        },
                        new
                        {
                            Id = new Guid("f63db583-c2dd-464a-911e-baf396e217c0"),
                            Description = "Click on the links and decide later",
                            IsCorrect = false,
                            ResponseOrder = 1,
                            ScenarioId = 4,
                            Text = "Click on the links provided, and have a look at the company’s online profile as well as reviews left by others. If all seems good, get in contact with the recruiter.",
                            Value = 1
                        },
                        new
                        {
                            Id = new Guid("06cf2ade-e4fa-4f2d-b291-58fdfb2f160f"),
                            Description = "Accept immediately and provide too much data",
                            IsCorrect = false,
                            ResponseOrder = 2,
                            ScenarioId = 4,
                            Text = "You have been job hunting for ages and see this as a blessing in disguise. You reply to the email saying that you would appreciate his help and attach a copy of your CV, a copy of your ID and a link to your GitHub account. (Since you know he will most likely request all this information anyway.",
                            Value = 2
                        },
                        new
                        {
                            Id = new Guid("64ce94e8-3f70-4b1a-8faf-37bd99c4ff38"),
                            Description = "Ignore and block",
                            IsCorrect = false,
                            ResponseOrder = 3,
                            ScenarioId = 4,
                            Text = "Ignore the email and remove the recruiter from your LinkedIn.",
                            Value = 3
                        },
                        new
                        {
                            Id = new Guid("422f5b65-a3ec-4891-8962-fd3ecf9dc20c"),
                            Description = "Use the number to arrange a meeting",
                            IsCorrect = true,
                            ResponseOrder = 4,
                            ScenarioId = 4,
                            Text = "Give the recruiter a call on one of the two numbers provided and arrange to meet up with him to discuss how he can help you.",
                            Value = 4
                        });
                });

            modelBuilder.Entity("SEval4.Models.EvalScenario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Context")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Feedback")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ScenarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EvaluationScenarios");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4361d2f9-9605-422a-b371-1927c3aa086d"),
                            Context = "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is very sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what user-name you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?",
                            Feedback = "Placeholder feedback 1",
                            ScenarioId = 3
                        },
                        new
                        {
                            Id = new Guid("950540fd-1d20-4a51-a986-a4f4a3475333"),
                            Context = "You are a Computer Science Honours student at UCT, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have a big network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in Cape Town. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position as of yet post studies? I’d be keen to have a chat with you to find out what It is that really interests you so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?",
                            Feedback = "Placeholder feedback 2",
                            ScenarioId = 4
                        });
                });

            modelBuilder.Entity("SEval4.Models.Participant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("AllocationTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsFinished")
                        .HasColumnType("bit");

                    b.Property<int?>("StudyGroupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudyGroupId");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("SEval4.Models.ParticipantSurvey", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AgeGroup")
                        .HasColumnType("int");

                    b.Property<int>("EducationGroup")
                        .HasColumnType("int");

                    b.Property<int>("HasFormalTraining")
                        .HasColumnType("int");

                    b.Property<int>("HasInformalTraining")
                        .HasColumnType("int");

                    b.Property<int>("HumanConfidence")
                        .HasColumnType("int");

                    b.Property<int>("PhishingConfidence")
                        .HasColumnType("int");

                    b.Property<int>("ProfessionalExperience")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ParticipantSurveys");
                });

            modelBuilder.Entity("SEval4.Models.Response", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResponseOrder")
                        .HasColumnType("int");

                    b.Property<int>("ScenarioId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e9440807-1dbb-4a25-93ed-79465f546666"),
                            Description = "Refuse immidately",
                            ResponseOrder = 1,
                            ScenarioId = 1,
                            Text = "Refuse to help her entirely and hang up the phone.",
                            Value = 1
                        },
                        new
                        {
                            Id = new Guid("c313d9ee-0004-493a-b49a-93dab893fc2f"),
                            Description = "Refer to colleague",
                            ResponseOrder = 2,
                            ScenarioId = 1,
                            Text = "Ask her to contact one of your colleagues since you are on holiday.",
                            Value = 2
                        },
                        new
                        {
                            Id = new Guid("5e2951c3-d9b8-4f9c-a96c-09372d137c30"),
                            Description = "Accept immediately",
                            ResponseOrder = 3,
                            ScenarioId = 1,
                            Text = "Instantly provide her with your login details and wish her a merry Christmas.",
                            Value = 3
                        },
                        new
                        {
                            Id = new Guid("b4695ffc-6a05-42db-976a-fbdcba65398a"),
                            Description = "Ask more questions and decide later",
                            ResponseOrder = 4,
                            ScenarioId = 1,
                            Text = "Ask her a few complementary questions and based on her answers either provide her with your login details or don’t provide her with any information.",
                            Value = 4
                        },
                        new
                        {
                            Id = new Guid("423382c2-31e6-4ff5-a889-c5c10468507b"),
                            Description = "Click on the links and decide later",
                            ResponseOrder = 1,
                            ScenarioId = 2,
                            Text = "Click on the links provided, and have a look at the company’s online profile as well as reviews left by others. If all seems good, get in contact with the recruiter.",
                            Value = 1
                        },
                        new
                        {
                            Id = new Guid("38776ecd-ca2f-4836-8a6a-f120cb434ba6"),
                            Description = "Accept immediately and provide too much data",
                            ResponseOrder = 2,
                            ScenarioId = 2,
                            Text = "You have been job hunting for ages and see this as a blessing in disguise. You reply to the email saying that you would appreciate his help and attach a copy of your CV, a copy of your ID and a link to your GitHub account. (Since you know he will most likely request all this information anyway.",
                            Value = 2
                        },
                        new
                        {
                            Id = new Guid("d0770bcf-a77d-414d-8dec-6bac0aadeeb0"),
                            Description = "Ignore and block",
                            ResponseOrder = 3,
                            ScenarioId = 2,
                            Text = "Ignore the email and remove the recruiter from your LinkedIn.",
                            Value = 3
                        },
                        new
                        {
                            Id = new Guid("0a21d069-dfe3-458e-b5fd-a3bc62f974df"),
                            Description = "Use the number to arrange a meeting",
                            ResponseOrder = 4,
                            ScenarioId = 2,
                            Text = "Give the recruiter a call on one of the two numbers provided and arrange to meet up with him to discuss how he can help you.",
                            Value = 4
                        });
                });

            modelBuilder.Entity("SEval4.Models.Scenario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Context")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ScenarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Scenarios");

                    b.HasData(
                        new
                        {
                            Id = new Guid("849e19dc-4f0c-4da7-b1e7-f4eda87b4bd1"),
                            Context = "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is very sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what user-name you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?",
                            ScenarioId = 1
                        },
                        new
                        {
                            Id = new Guid("f50e2b0c-9db7-4d17-9411-df767c296dac"),
                            Context = "You are a Computer Science Honours student at UCT, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have a big network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in Cape Town. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position as of yet post studies? I’d be keen to have a chat with you to find out what It is that really interests you so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?",
                            ScenarioId = 2
                        });
                });

            modelBuilder.Entity("SEval4.Models.YearGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("YearGroups");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5df3c9a2-3ee2-4a96-bc36-116f854a254f"),
                            Text = "1 year or less",
                            Value = 1
                        },
                        new
                        {
                            Id = new Guid("c82a2568-34d3-4de6-a597-efbc6fd40966"),
                            Text = "2 - 3 years",
                            Value = 2
                        },
                        new
                        {
                            Id = new Guid("6aae7e6b-291c-4be4-9340-fcc76fc68342"),
                            Text = "4 - 5 years",
                            Value = 3
                        },
                        new
                        {
                            Id = new Guid("50534b13-7fa2-4872-a7f8-7359cd593ffb"),
                            Text = "6 years or more",
                            Value = 4
                        });
                });

            modelBuilder.Entity("SEval4.StudyGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StudyGroups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "SEADM"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Feedback"
                        });
                });

            modelBuilder.Entity("SEval4.Models.Participant", b =>
                {
                    b.HasOne("SEval4.StudyGroup", "StudyGroup")
                        .WithMany()
                        .HasForeignKey("StudyGroupId");

                    b.Navigation("StudyGroup");
                });
#pragma warning restore 612, 618
        }
    }
}
