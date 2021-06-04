using SEval4.Models;
using System;

namespace SEval4.Data
{
    public static class SeedSurvey
    {
        #region Study groups

        public static readonly StudyGroup[] StudyGroupsSeed =
        {
            new StudyGroup
            {
                Id = 1,
                Name = "SEADM",
                Identifier = new Guid("c43e55f6-cf02-4cc2-bbd6-601b37f0beb1"),
            },
            new StudyGroup
            {
                Id = 2,
                Name = "Feedback",
                Identifier = new Guid("7a8d2920-cb1c-4f7b-8513-1dc19a2c9634"),
            }
        };

        #endregion

        #region DropDown options

        #region Participant survey

        public static readonly AgeGroup[] AgeGroupsSeed =
        {
            new AgeGroup
            {
                // Id = 1,
                Text = "18 - 24 years old",
                Id = 1,
            },
            new AgeGroup
            {
                // Id = 2,
                Text = "25 - 34 years old",
                Id = 2,
            },
            new AgeGroup
            {
                // Id = 3,
                Text = "35 - 44 years old",
                Id = 3,
            },
            new AgeGroup
            {
                // Id = 4,
                Text = "45 - 54 years old",
                Id = 4,
            },
            new AgeGroup
            {
                // Id = 5,
                Text = "55 - 64 years old",
                Id = 5,
            },
            new AgeGroup
            {
                // Id = 6,
                Text = "65+ years old",
                Id = 6,
            },
        };

        public static readonly YearGroup[] YearGroupsSeed =
        {
            new YearGroup
            {
                // Id = 1,
                Text = "1 year or less",
                Id = 1,
            },
            new YearGroup
            {
                // Id = 2,
                Text = "2 - 3 years",
                Id = 2,
            },
            new YearGroup
            {
                // Id = 3,
                Text = "4 - 5 years",
                Id = 3,
            },
            new YearGroup
            {
                // Id = 4,
                Text = "6 years or more",
                Id = 4,
            },
        };

        public static readonly EducationGroup[] EducationGroupsSeed =
        {
            new EducationGroup
            {
                // Id = 1,
                Text = "Primary Education",
                Id = 1,
            },
            new EducationGroup
            {
                // Id = 2,
                Text = "Secondary Education",
                Id = 2,
            },
            new EducationGroup
            {
                // Id = 3,
                Text = "Vocational training",
                Id = 3,
            },
            new EducationGroup
            {
                // Id = 4,
                Text = "Bachelor degree or equivalent",
                Id = 4,
            },
            new EducationGroup
            {
                // Id = 5,
                Text = "Postgraduate Master",
                Id = 5,
            },
            new EducationGroup
            {
                // Id = 6,
                Text = "PhD",
                Id = 6,
            },
        };

        public static readonly ConfidenceGroup[] ConfidenceGroupsSeed =
        {
            new ConfidenceGroup
            {
                // Id = 1,
                Text = "No confidence",
                Id = 1,
            },
            new ConfidenceGroup
            {
                // Id = 2,
                Text = "Low confidence",
                Id = 2,
            },
            new ConfidenceGroup
            {
                // Id = 3,
                Text = "Moderate confidence",
                Id = 3,
            },
            new ConfidenceGroup
            {
                // Id = 4,
                Text = "High confidence",
                Id = 4,
            },
            new ConfidenceGroup
            {
                // Id = 5,
                Text = "Full confidence",
                Id = 5,
            },

        };

        #endregion

        #region Feedback

        public static readonly StudyHelpfulness[] StudyHelpfulnessSeed =
        {
            new StudyHelpfulness
            {
                Id = 1,
                Text = "Very helpful",
            },
            new StudyHelpfulness
            {
                Id = 2,
                Text = "Somewhat helpful",
            },
            new StudyHelpfulness
            {
                Id = 3,
                Text = "Unsure",
            },
            new StudyHelpfulness
            {
                Id = 4,
                Text = "A little helpful",
            },
            new StudyHelpfulness
            {
                Id = 5,
                Text = "Not helpful at all",
            },
        };

        public static readonly ConfidenceChange[] ConfidenceChangeSeed =
        {
            new ConfidenceChange
            {
                Id = 1,
                Text = "Very positively",
            },
            new ConfidenceChange
            {
                Id = 2,
                Text = "Somewhat positively",
            },
            new ConfidenceChange
            {
                Id = 3,
                Text = "No change at all",
            },
            new ConfidenceChange
            {
                Id = 4,
                Text = "Somewhat negatively",
            },
            new ConfidenceChange
            {
                Id = 5,
                Text = "Very negatively",
            },
        };

        #endregion

        #endregion

        #region Baseline and Postgame

        public static readonly Scenario[] ScenariosSeed =
        {
            new Scenario
            {
                Id = 1,
                Context = "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much-needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is deeply sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what username you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?",
            },
            new Scenario
            {
                Id = 2,
                Context = "You are sitting at your desk working. It is an ordinary Thursday in late September, and you do not really have all that much to do. You get an email, from a new email address, saying that a new person at your company’s external accounting firm has started to work on the time reports, and she needs your preliminary time report (a document detailing the number of hours you have worked) mailed to her email at the accounting firm as soon as possible, preferably today, as the end of the quarter is coming up and the owners have requested financial information as soon as possible. You do take note, however, that the email address which this email was sent from has the same domain as all other emails which you have received from the accounting firm in the past. In addition, the style of the email’s signature is the same as the style of the signatures of all previous emails received from various other people working at the accounting firm. Which action do you take?",
            },
            new Scenario
            {
                Id = 3,
                Context = "You are a Computer Science Honours student at University of Aberdeen, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have an extensive network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in UK. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position yet post studies? I would be keen to have a chat with you to find out what It is that really interests you, so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?",
            },
            new Scenario
            {
                Id = 4,
                Context = "You receive a message on the Facebook Messenger app from someone who is not your friend on Facebook. The person who sent you the message, claims to be a marketing agent for a local festival. He tells you about a competition to win free tickets to the festival. You really wanted to attend this festival and the sound of winning free tickets gets you very excited, however you decide to have a look at the festival’s website, to confirm there is really a competition running. After having a look at the website, you see that there is really a competition running and that all you must do is submit a video of yourself showing how excited you are about the festival and showing off your festival dance moves. You decide to thank the person who sent you a message on Facebook Messenger, since you are grateful for finding out about this competition. The person responds saying that it is no problem at all, and he is happy to help. He goes on to ask if you would not mind him assisting you with your entry, because, he explains, that if he helps you, he will get commission. You are not all that technically savvy and you would not mind the help, so you respond saying thanking him for his offer and saying that you would really appreciate his help. He responds saying that it is no problem at all. He tells you that all you will need to do is send him your entry video via Facebook Messenger as well as your full name, date of birth and Facebook login details (email and password), since an entry into the competition requires a link to your Facebook account. Which action do you take?",
            },
            new Scenario
            {
                Id = 5,
                Context = "Whilst walking on campus you see a flash drive lying on the ground. You pick up the flash drive and notice that there are no identifiable traits on the outer shell of the flash drive that can be used to identify the owner. As you have lost several flash drives before, you feel sorry for the owner of this flash drive. You are aware of how much work could potentially be lost that may be saved on the flash drive. Which action do you take?",
            },
            new Scenario
            {
                Id = 6,
                Context = "Whilst walking towards the entrance turnstile at the computer lab, a person whom you have never met or seen before approaches you. This person looks to be in their early 20s and looks like a fellow student. The person tells you that he has forgotten his student card at home and can now not enter through the turnstile to use the computers in the lab. The person asks if you could assist him with entering through the turnstile by allowing him to swipe in using your student card. Your card allows you to both swipe in and enter the computer lab. The person looks incredibly stressed and tells you he has an assignment due in 15 minutes that he needs to get access to a computer to submit. You know that there are policies in place that disallow swiping in other students to labs, however it will not harm you in any way to swipe in a fellow student and you could help him pass the course by helping him get to a computer to submit his assignment on time. Which action do you take?",
            },
            new Scenario
            {
                Id = 7,
                Context = "A day before an assignment is due you receive an email from a fellow student. You have never met this student before, but in the email the student says he is in the same class as you and that he got your email address from the participants section on the course’s Blackboard tab. Attached to the email is a PDF of that student’s assignment. The student says that he is not sure if his answers are correct, and he would really appreciate your help. He asks you to please read through his assignment, compare his answers to yours and then let him know if there are any differences. You open the attached PDF and can clearly see that the student has done the assignment. Which action do you take?",
            },
            new Scenario
            {
                Id = 8,
                Context = "You are busy working in the computer labs on an important assignment that must be handed in within the next 30 minutes. You also have another application open which is monitoring your incoming emails. You receive an email from your lecturer who has given you the assignment and the email is related to the assignment which you are busy with. The email provides you with a different submission link than the one you originally had for submitting the assignment. You are fairly sure that this email is from this lecturer, however it is extremely uncommon for this lecturer to send out emails directly to the students. Communication such as this one is normally communicated via the announcement system on the course’s Blackboard page. Which action do you take?",
            },
            new Scenario
            {
                Id = 9,
                Context = "You are sitting in one of the classes that you attend every week. Your lecturer walks into the class and introduces a guest lecturer to you from an external organisation. The guest lecturer provides a brief explanation about his organisation and that he is extremely grateful to be speaking directly to the students. The guest lecturer provides the students with a small assignment to perform. The guest lecturer informs the students that this assignment will count towards their marks for the end of the year. Upon receiving the assignment, you find that apart from requesting your student number, you are also requested to provide your date of birth as well as the last 4 digits of your identification document (ID) number. While you are considering whether you are going to provide this information, the guest lecturer assures you that this information will only be used for recruitment purposes later on. Which action do you take?",
            },
            new Scenario
            {
                Id = 10,
                Context = "You have been working on a major project for a customer for a long time. The project has been quite stressful in periods, and calmer in others. It has been a rewarding project, and you think it is a little sad that it is soon to end. The project has involved a number of offices in several countries, as well as many people. The project also uses special software, especially developed for this project. You do not know that much about how it works, as you have mostly been involved at an overall level. At the moment you are sitting trying to finish the last of this week's documentation in order to leave for the weekend. You get a call from a 'Jacob', from technical support, which is stationed in San Francisco. He explains that you seem to be running a previous version of the software, something that has given them severe problems as it hinders the encryption from working correctly, because it uses another system for the public keys. Jacob directs you to a link where a more recent version can be found and asks you to install it as soon as possible and to log in again to stop the problems.",
            }
        };

        public static readonly Response[] ResponsesSeed =
        {
            // Scenario 1
            new Response
            {
                Id = 1,
                ScenarioId = 1,
                Value = 1,
                Description = "Accept instantly",
                Text = "Instantly provide her with your login details and wish her a merry Christmas.",
            },
            new Response
            {
                Id = 2,
                ScenarioId = 1,
                Value = 2,
                Description = "Ask to elaborate and decide later",
                Text = "Ask her a few complementary questions and based on her answers either provide her with your login details or do not provide her with any information.",
            },
            new Response
            {
                Id = 3,
                ScenarioId = 1,
                Value = 3,
                Description = "Reject",
                Text = "Refuse to help her entirely and hang up the phone.",
                IsCorrect = true,
            },
            new Response
            {
                Id = 4,
                ScenarioId = 1,
                Value = 4,
                Description = "Defer to colleague",
                Text = "Ask her to contact one of your colleagues since you are on holiday.",
            },


            // Scenario 2
            new Response
            {
                Id = 5,
                ScenarioId = 2,
                Value = 1,
                Description = "Ask to elaborate and decide later",
                Text = "Reply to the email, asking her a few complementary questions and based on her answers either provide her your preliminary time report or refuse to send it to her.",
            },
            new Response
            {
                Id = 6,
                ScenarioId = 2,
                Value = 2,
                Description = "Validate through 3rd party",
                Text = "Contact your superior to find out whether they approve of you sending your preliminary time report to the person requesting it or not.",
                IsCorrect = true,
            },
            new Response
            {
                Id = 7,
                ScenarioId = 2,
                Value = 3,
                Description = "Refuse",
                Text = "Refuse to send her your preliminary time report.",
            },
            new Response
            {
                Id = 8,
                ScenarioId = 2,
                Value = 4,
                Description = "Accept immediately",
                Text = "Since you do not have much work to do, you get working on your preliminary time report immediately and email it to the requester as soon as possible.",
            },


            // Scenario 3
            new Response
            {
                Id = 9,
                ScenarioId = 3,
                Value = 1,
                Description = "Validate through requester-provided links",
                Text = "Click on the links provided and have a look at the company's online profile as well as reviews left by others. If all seems good, contact the recruiter.",
            },
            new Response
            {
                Id = 10,
                ScenarioId = 3,
                Value = 2,
                Description = "Accept / Call the recruiter's nubmer and arrange a meeting",
                Text = "Give the recruiter a call on one of the two numbers provided and arrange a video call with him to discuss how he can help you.",
                IsCorrect = true,
            },
            new Response
            {
                Id = 11,
                ScenarioId = 3,
                Value = 3,
                Description = "Give too much data",
                Text = "You have been job hunting for ages and see this as a blessing in disguise. You reply to the email saying that you would appreciate his help and attach a copy of your CV, a copy of your ID and a link to your GitHub account. (Since you know he will most likely request all this information anyway.",
            },
            new Response
            {
                Id = 12,
                ScenarioId = 3,
                Value = 4,
                Description = "Reject",
                Text = "Ignore the email and remove the recruiter from your LinkedIn.",
            },


            // Scenario 4
            new Response
            {
                Id = 13,
                ScenarioId = 4,
                Value = 1,
                Description = "Enter competition through official means",
                Text = "Record your video in a few days but decide to enter the competition yourself instead by going to the official festival website and entering the competition there, without sending the person on Facebook Messenger any of your details.",
                IsCorrect = true,
            },
            new Response
            {
                Id = 14,
                ScenarioId = 4,
                Value = 2,
                Description = "Accept",
                Text = "Record your video in a few days and send him your video along with all the information requested, since he only needs it to enter you into the competition.",
            },
            new Response
            {
                Id = 15,
                ScenarioId = 4,
                Value = 3,
                Description = "Accept and change login details 24h later",
                Text = "Record your video in a few days and send him your video along with all the information requested, however you are a bit wary about giving out your Facebook login details and decide to change your Facebook password 24 hours after sending it to him.",
            },
            new Response
            {
                Id = 16,
                ScenarioId = 4,
                Value = 4,
                Description = "Distrust the whole competition",
                Text = "Decide not to enter the competition at all. Since the person on Facebook was asking for your Facebook login details for the competition, you conclude that the entire competition must be fake and decide that it is best not to enter.",
            },


            // Scenario 5
            new Response
            {
                Id = 17,
                ScenarioId = 5,
                Value = 1,
                Description = "Ask a friend to check the drive",
                Text = "Give the flash drive to a friend and ask them to try identifying the owner by examining the files on their computer.",
            },
            new Response
            {
                Id = 18,
                ScenarioId = 5,
                Value = 2,
                Description = "Check drive on virtual machine",
                Text = "You decide to install a virtual machine on your computer and use that virtual machine to examine all folders and open all files on the flash drive in an attempt to identify the owner.",
                IsCorrect = true,
            },
            new Response
            {
                Id = 19,
                ScenarioId = 5,
                Value = 3,
                Description = "Scan for viruses and check the drive",
                Text = "You first scan the flash drive for viruses and if it is found to be virus free, start examining all folders and opening all files stored on the flash drive to hopefully identify the owner.",
            },
            new Response
            {
                Id = 20,
                ScenarioId = 5,
                Value = 4,
                Description = "Leave the drive where it is",
                Text = "Leave the flash drive where it is, without plugging it into any computer or opening any of the files.",
            },


            // Scenario 6
            new Response
            {
                Id = 21,
                ScenarioId = 6,
                Value = 1,
                Description = "Ask to elaborate and decide later",
                Text = "Even though the student is stressed and needs to get into the lab as soon as possible, you decide to ask the student a few questions and based on his/her answers decide on whether to swipe them in or not.",
            },
            new Response
            {
                Id = 22,
                ScenarioId = 6,
                Value = 2,
                Description = "Refuse",
                Text = "Refuse to help the student at all and tell them they should not have waited till the last minute to submit their assignment and they should always have their student card on them while on campus.",
            },
            new Response
            {
                Id = 23,
                ScenarioId = 6,
                Value = 3,
                Description = "Accept",
                Text = "Swipe the student in immediately, since you know how stressful it is submitting an assignment at the last minute and you know there is no time to waste.",
            },
            new Response
            {
                Id = 24,
                ScenarioId = 6,
                Value = 4,
                Description = "Defer to reception",
                Text = "Give the student directions to the access control offices where the student can prove their identity and hopefully get access to a computer lab within 15 minutes to submit their assignment.",
                IsCorrect = true,
            },


            // Scenario 7
            new Response
            {
                Id = 25,
                ScenarioId = 7,
                Value = 1,
                Description = "Accept and use his answers",
                Text = "You see this as a life saver and decide to use this to your advantage by comparing his answers to yours and using his answers to help you finish your assignment. You then also reply to his email telling him where your answers were different to his.",
            },
            new Response
            {
                Id = 26,
                ScenarioId = 7,
                Value = 2,
                Description = "Reject but use his answers",
                Text = "You see this as a life saver and decide to use this to your advantage by comparing his answers to yours and using his answers to help you finish your assignment. You do not respond to his email, however, since you do not know him and would not want his answers to be identical to yours out of fear of being caught for plagiarism.",
            },
            new Response
            {
                Id = 27,
                ScenarioId = 7,
                Value = 3,
                Description = "Reject and do not use his answers",
                Text = "You close the PDF immediately after opening it and delete it. You do not respond to the email and decide to complete your assignment on your own without comparing your answers to the answers sent to you by the student.",
                IsCorrect = true,
            },
            new Response
            {
                Id = 28,
                ScenarioId = 7,
                Value = 4,
                Description = "Reject but send him your answers",
                Text = "You are terribly busy finishing off your assignment and do not have time to look at his answers. You therefore decide to just send him your assignment so far and say he is welcome to compare answers, but you do not have time.",
            },


            // Scenario 8
            new Response
            {
                Id = 29,
                ScenarioId = 8,
                Value = 1,
                Description = "Reject",
                Text = "Deny the new submission link and use the old (original) submission link instead.",
            },
            new Response
            {
                Id = 30,
                ScenarioId = 8,
                Value = 2,
                Description = "Accept",
                Text = "Submit the assignment to the new link, without asking any questions.",
            },
            new Response
            {
                Id = 31,
                ScenarioId = 8,
                Value = 3,
                Description = "Confirm through 3rd party",
                Text = "You ask your friend whether they also received the email and based on your friend's answer decide where to submit your assignment.",
                IsCorrect = true,
            },
            new Response
            {
                Id = 32,
                ScenarioId = 8,
                Value = 4,
                Description = "Ask to elaborate and decide later",
                Text = "You reply to the lecturer's email asking a few complementary questions, before accepting the new link to be correct and submitting to it.",
            },


            // Scenario 9
            new Response
            {
                Id = 33,
                ScenarioId = 9,
                Value = 1,
                Description = "Ask to elaborate and decide later",
                Text = "Ask the guest lecturer a few complementary questions and based on his answers decide whether to provide the information.",
            },
            new Response
            {
                Id = 34,
                ScenarioId = 9,
                Value = 2,
                Description = "Defer to the lecturer",
                Text = "Ask the guest lecturer to contact your lecturer directly to obtain this information.",
                IsCorrect = true,
            },
            new Response
            {
                Id = 35,
                ScenarioId = 9,
                Value = 3,
                Description = "Reject",
                Text = "Do not provide the information and do not tell the guest lecturer where to get it as I deem it to be sensitive information.",
            },
            new Response
            {
                Id = 36,
                ScenarioId = 9,
                Value = 4,
                Description = "Accept",
                Text = "Provide all the requested information.",
            },


            // Scenario 10
            new Response
            {
                Id = 37,
                ScenarioId = 10,
                Value = 1,
                Description = "Ask to elaborate and decide later",
                Text = "I ask several complementary questions before I comply by clicking the download link.",
            },
            new Response
            {
                Id = 38,
                ScenarioId = 10,
                Value = 2,
                Description = "Ask to elaborate and request time to evaluate later",
                Text = "I ask complementary questions and ask if I can come back to him at a later stage.",
            },
            new Response
            {
                Id = 39,
                ScenarioId = 10,
                Value = 3,
                Description = "Reject",
                Text = "I do not comply with his request at all.",
                IsCorrect = true,
            },
            new Response
            {
                Id = 40,
                ScenarioId = 10,
                Value = 4,
                Description = "Accept",
                Text = "I instantly comply and follow the new download link.",
            },
        };

        #endregion

        #region Evaluation 

        public static readonly EvalScenario[] EvalScenariosSeed =
        {
            new EvalScenario
            {
                Id = 1,
                Context = "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much-needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is deeply sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what username you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?",
                Feedback = "Placeholder feedback 1",
            },
            new EvalScenario
            {
                Id = 2,
                Context = "You are sitting at your desk working. It is an ordinary Thursday in late September, and you do not really have all that much to do. You get an email, from a new email address, saying that a new person at your company’s external accounting firm has started to work on the time reports, and she needs your preliminary time report (a document detailing the number of hours you have worked) mailed to her email at the accounting firm as soon as possible, preferably today, as the end of the quarter is coming up and the owners have requested financial information as soon as possible. You do take note, however, that the email address which this email was sent from has the same domain as all other emails which you have received from the accounting firm in the past. In addition, the style of the email’s signature is the same as the style of the signatures of all previous emails received from various other people working at the accounting firm. Which action do you take?",
                Feedback = "Placeholder feedback 2",
            },
            new EvalScenario
            {
                Id = 3,
                Context = "You are a Computer Science Honours student at University of Aberdeen, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have an extensive network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in UK. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position yet post studies? I would be keen to have a chat with you to find out what It is that really interests you, so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?",
                Feedback = "Placeholder feedback 2",
            },
            new EvalScenario
            {
                Id = 4,
                Context = "You receive a message on the Facebook Messenger app from someone who is not your friend on Facebook. The person who sent you the message, claims to be a marketing agent for a local festival. He tells you about a competition to win free tickets to the festival. You really wanted to attend this festival and the sound of winning free tickets gets you very excited, however you decide to have a look at the festival’s website, to confirm there is really a competition running. After having a look at the website, you see that there is really a competition running and that all you must do is submit a video of yourself showing how excited you are about the festival and showing off your festival dance moves. You decide to thank the person who sent you a message on Facebook Messenger, since you are grateful for finding out about this competition. The person responds saying that it is no problem at all, and he is happy to help. He goes on to ask if you would not mind him assisting you with your entry, because, he explains, that if he helps you, he will get commission. You are not all that technically savvy and you would not mind the help, so you respond saying thanking him for his offer and saying that you would really appreciate his help. He responds saying that it is no problem at all. He tells you that all you will need to do is send him your entry video via Facebook Messenger as well as your full name, date of birth and Facebook login details (email and password), since an entry into the competition requires a link to your Facebook account. Which action do you take?",
                Feedback = "Placeholder feedback 2",
            },
            //new EvalScenario
            //{
            //    Id = 5,
            //    Context = "Whilst walking on campus you see a flash drive lying on the ground. You pick up the flash drive and notice that there are no identifiable traits on the outer shell of the flash drive that can be used to identify the owner. As you have lost several flash drives before, you feel sorry for the owner of this flash drive. You are aware of how much work could potentially be lost that may be saved on the flash drive. Which action do you take?",
            //    Feedback = "Placeholder feedback 2",
            //},
            //new EvalScenario
            //{
            //    Id = 6,
            //    Context = "Whilst walking towards the entrance turnstile at the computer lab, a person whom you have never met or seen before approaches you. This person is about the same age as you and looks like a fellow student. The person tells you that he has forgotten his student card at home and can now not enter through the turnstile to use the computers in the lab. The person asks if you could assist him with entering through the turnstile by allowing him to swipe in using your student card. Your card allows you to both swipe in and enter the computer lab. The person looks incredibly stressed and tells you he has an assignment due in 15 minutes that he needs to get access to a computer to submit. You know that there are policies in place that disallow swiping in other students to labs, however it will not harm you in any way to swipe in a fellow student and you could help him pass the course by helping him get to a computer to submit his assignment on time. Which action do you take?",
            //    Feedback = "Placeholder feedback 2",
            //},
            //new EvalScenario
            //{
            //    Id = 7,
            //    Context = "A day before an assignment is due you receive an email from a fellow student. You have never met this student before, but in the email the student says he is in the same class as you and that he got your email address from the participants section on the course’s Blackboard tab. Attached to the email is a PDF of that student’s assignment. The student says that he is not sure if his answers are correct, and he would really appreciate your help. He asks you to please read through his assignment, compare his answers to yours and then let him know if there are any differences. You open the attached PDF and can clearly see that the student has done the assignment. Which action do you take?",
            //    Feedback = "Placeholder feedback 2",
            //},
            //new EvalScenario
            //{
            //    Id = 8,
            //    Context = "You are busy working in the computer labs on an important assignment that must be handed in within the next 30 minutes. You also have another application open which is monitoring your incoming emails. You receive an email from your lecturer who has given you the assignment and the email is related to the assignment which you are busy with. The email provides you with a different submission link than the one you originally had for submitting the assignment. You are fairly sure that this email is from this lecturer, however it is extremely uncommon for this lecturer to send out emails directly to the students. Communication such as this one is normally communicated via the announcement system on the course’s Blackboard page. Which action do you take?",
            //    Feedback = "Placeholder feedback 2",
            //},
            //new EvalScenario
            //{
            //    Id = 9,
            //    Context = "You are sitting in one of the classes that you attend every week. Your lecturer walks into the class and introduces a guest lecturer to you from an external organisation. The guest lecturer provides a brief explanation about his organisation and that he is extremely grateful to be speaking directly to the students. The guest lecturer provides the students with a small assignment to perform. The guest lecturer informs the students that this assignment will count towards their marks for the end of the year. Upon receiving the assignment, you find that apart from requesting your student number, you are also requested to provide your date of birth as well as the last 4 digits of your identification document (ID) number. While you are considering whether you are going to provide this information, the guest lecturer assures you that this information will only be used for recruitment purposes later on. Which action do you take?",
            //    Feedback = "Placeholder feedback 2",
            //},
            //new EvalScenario
            //{
            //    Id = 10,
            //    Context = "You have been working on a major project for a customer for a long time. The project has been quite stressful in periods, and calmer in others. It has been a rewarding project, and you think it is a little sad that it is soon to end. The project has involved a number of offices in several countries, as well as many people. The project also uses special software, especially developed for this project. You do not know that much about how it works, as you have mostly been involved at an overall level. At the moment you are sitting trying to finish the last of this week's documentation in order to leave for the weekend. You get a call from a 'Jacob', from technical support, which is stationed in San Francisco. He explains that you seem to be running a previous version of the software, something that has given them severe problems as it hinders the encryption from working correctly, because it uses another system for the public keys. Jacob directs you to a link where a more recent version can be found and asks you to install it as soon as possible and to log in again to stop the problems.",
            //    Feedback = "Placeholder feedback 2",
            //}
        };

        public static readonly EvalResponse[] EvalResponsesSeed =
        {
            // Scenario 1
            new EvalResponse
            {
                Id = 1,
                ScenarioId = 1,
                Value = 1,
                Description = "Accept instantly",
                Text = "Instantly provide her with your login details and wish her a merry Christmas.",
            },
            new EvalResponse
            {
                Id = 2,
                ScenarioId = 1,
                Value = 2,
                Description = "Ask to elaborate and decide later",
                Text = "Ask her a few complementary questions and based on her answers either provide her with your login details or do not provide her with any information.",
            },
            new EvalResponse
            {
                Id = 3,
                ScenarioId = 1,
                Value = 3,
                Description = "Reject",
                Text = "Refuse to help her entirely and hang up the phone.",
                IsCorrect = true,
            },
            new EvalResponse
            {
                Id = 4,
                ScenarioId = 1,
                Value = 4,
                Description = "Defer to colleague",
                Text = "Ask her to contact one of your colleagues since you are on holiday.",
            },


            // Scenario 2
            new EvalResponse
            {
                Id = 5,
                ScenarioId = 2,
                Value = 1,
                Description = "Ask to elaborate and decide later",
                Text = "Reply to the email, asking her a few complementary questions and based on her answers either provide her your preliminary time report or refuse to send it to her.",
            },
            new EvalResponse
            {
                Id = 6,
                ScenarioId = 2,
                Value = 2,
                Description = "Validate through 3rd party",
                Text = "Contact your superior to find out whether they approve of you sending your preliminary time report to the person requesting it or not.",
                IsCorrect = true,
            },
            new EvalResponse
            {
                Id = 7,
                ScenarioId = 2,
                Value = 3,
                Description = "Refuse",
                Text = "Refuse to send her your preliminary time report.",
            },
            new EvalResponse
            {
                Id = 8,
                ScenarioId = 2,
                Value = 4,
                Description = "Accept immediately",
                Text = "Since you do not have much work to do, you get working on your preliminary time report immediately and email it to the requester as soon as possible.",
            },


            // Scenario 3
            new EvalResponse
            {
                Id = 9,
                ScenarioId = 3,
                Value = 1,
                Description = "Validate through requester-provided links",
                Text = "Click on the links provided and have a look at the company's online profile as well as reviews left by others. If all seems good, contact the recruiter.",
            },
            new EvalResponse
            {
                Id = 10,
                ScenarioId = 3,
                Value = 2,
                Description = "Accept / Call the recruiter's nubmer and arrange a meeting",
                Text = "Give the recruiter a call on one of the two numbers provided and arrange a video call with him to discuss how he can help you.",
                IsCorrect = true,
            },
            new EvalResponse
            {
                Id = 11,
                ScenarioId = 3,
                Value = 3,
                Description = "Give too much data",
                Text = "You have been job hunting for ages and see this as a blessing in disguise. You reply to the email saying that you would appreciate his help and attach a copy of your CV, a copy of your ID and a link to your GitHub account. (Since you know he will most likely request all this information anyway.",
            },
            new EvalResponse
            {
                Id = 12,
                ScenarioId = 3,
                Value = 4,
                Description = "Reject",
                Text = "Ignore the email and remove the recruiter from your LinkedIn.",
            },


            // Scenario 4
            new EvalResponse
            {
                Id = 13,
                ScenarioId = 4,
                Value = 1,
                Description = "Enter competition through official means",
                Text = "Record your video in a few days but decide to enter the competition yourself instead by going to the official festival website and entering the competition there, without sending the person on Facebook Messenger any of your details.",
                IsCorrect = true,
            },
            new EvalResponse
            {
                Id = 14,
                ScenarioId = 4,
                Value = 2,
                Description = "Accept",
                Text = "Record your video in a few days and send him your video along with all the information requested, since he only needs it to enter you into the competition.",
            },
            new EvalResponse
            {
                Id = 15,
                ScenarioId = 4,
                Value = 3,
                Description = "Accept and change login details 24h later",
                Text = "Record your video in a few days and send him your video along with all the information requested, however you are a bit wary about giving out your Facebook login details and decide to change your Facebook password 24 hours after sending it to him.",
            },
            new EvalResponse
            {
                Id = 16,
                ScenarioId = 4,
                Value = 4,
                Description = "Distrust the whole competition",
                Text = "Decide not to enter the competition at all. Since the person on Facebook was asking for your Facebook login details for the competition, you conclude that the entire competition must be fake and decide that it is best not to enter.",
            },


            // Scenario 5
            new EvalResponse
            {
                Id = 17,
                ScenarioId = 5,
                Value = 1,
                Description = "Ask a friend to check the drive",
                Text = "Give the flash drive to a friend and ask them to try identifying the owner by examining the files on their computer.",
            },
            new EvalResponse
            {
                Id = 18,
                ScenarioId = 5,
                Value = 2,
                Description = "Check drive on virtual machine",
                Text = "You decide to install a virtual machine on your computer and use that virtual machine to examine all folders and open all files on the flash drive in an attempt to identify the owner.",
                IsCorrect = true,
            },
            new EvalResponse
            {
                Id = 19,
                ScenarioId = 5,
                Value = 3,
                Description = "Scan for viruses and check the drive",
                Text = "You first scan the flash drive for viruses and if it is found to be virus free, start examining all folders and opening all files stored on the flash drive to hopefully identify the owner.",
            },
            new EvalResponse
            {
                Id = 20,
                ScenarioId = 5,
                Value = 4,
                Description = "Leave the drive where it is",
                Text = "Leave the flash drive where it is, without plugging it into any computer or opening any of the files.",
            },


            // Scenario 6
            new EvalResponse
            {
                Id = 21,
                ScenarioId = 6,
                Value = 1,
                Description = "Ask to elaborate and decide later",
                Text = "Even though the student is stressed and needs to get into the lab as soon as possible, you decide to ask the student a few questions and based on his/her answers decide on whether to swipe them in or not.",
            },
            new EvalResponse
            {
                Id = 22,
                ScenarioId = 6,
                Value = 2,
                Description = "Refuse",
                Text = "Refuse to help the student at all and tell them they should not have waited till the last minute to submit their assignment and they should always have their student card on them while on campus.",
            },
            new EvalResponse
            {
                Id = 23,
                ScenarioId = 6,
                Value = 3,
                Description = "Accept",
                Text = "Swipe the student in immediately, since you know how stressful it is submitting an assignment at the last minute and you know there is no time to waste.",
            },
            new EvalResponse
            {
                Id = 24,
                ScenarioId = 6,
                Value = 4,
                Description = "Defer to reception",
                Text = "Give the student directions to the access control offices where the student can prove their identity and hopefully get access to a computer lab within 15 minutes to submit their assignment.",
                IsCorrect = true,
            },


            // Scenario 7
            new EvalResponse
            {
                Id = 25,
                ScenarioId = 7,
                Value = 1,
                Description = "Accept and use his answers",
                Text = "You see this as a life saver and decide to use this to your advantage by comparing his answers to yours and using his answers to help you finish your assignment. You then also reply to his email telling him where your answers were different to his.",
            },
            new EvalResponse
            {
                Id = 26,
                ScenarioId = 7,
                Value = 2,
                Description = "Reject but use his answers",
                Text = "You see this as a life saver and decide to use this to your advantage by comparing his answers to yours and using his answers to help you finish your assignment. You do not respond to his email, however, since you do not know him and would not want his answers to be identical to yours out of fear of being caught for plagiarism.",
            },
            new EvalResponse
            {
                Id = 27,
                ScenarioId = 7,
                Value = 3,
                Description = "Reject and do not use his answers",
                Text = "You close the PDF immediately after opening it and delete it. You do not respond to the email and decide to complete your assignment on your own without comparing your answers to the answers sent to you by the student.",
                IsCorrect = true,
            },
            new EvalResponse
            {
                Id = 28,
                ScenarioId = 7,
                Value = 4,
                Description = "Reject but send him your answers",
                Text = "You are terribly busy finishing off your assignment and do not have time to look at his answers. You therefore decide to just send him your assignment so far and say he is welcome to compare answers, but you do not have time.",
            },


            // Scenario 8
            new EvalResponse
            {
                Id = 29,
                ScenarioId = 8,
                Value = 1,
                Description = "Reject",
                Text = "Deny the new submission link and use the old (original) submission link instead.",
            },
            new EvalResponse
            {
                Id = 30,
                ScenarioId = 8,
                Value = 2,
                Description = "Accept",
                Text = "Submit the assignment to the new link, without asking any questions.",
            },
            new EvalResponse
            {
                Id = 31,
                ScenarioId = 8,
                Value = 3,
                Description = "Confirm through 3rd party",
                Text = "You ask your friend whether they also received the email and based on your friend's answer decide where to submit your assignment.",
                IsCorrect = true,
            },
            new EvalResponse
            {
                Id = 32,
                ScenarioId = 8,
                Value = 4,
                Description = "Ask to elaborate and decide later",
                Text = "You reply to the lecturer's email asking a few complementary questions, before accepting the new link to be correct and submitting to it.",
            },


            // Scenario 9
            new EvalResponse
            {
                Id = 33,
                ScenarioId = 9,
                Value = 1,
                Description = "Ask to elaborate and decide later",
                Text = "Ask the guest lecturer a few complementary questions and based on his answers decide whether to provide the information.",
            },
            new EvalResponse
            {
                Id = 34,
                ScenarioId = 9,
                Value = 2,
                Description = "Defer to the lecturer",
                Text = "Ask the guest lecturer to contact your lecturer directly to obtain this information.",
                IsCorrect = true,
            },
            new EvalResponse
            {
                Id = 35,
                ScenarioId = 9,
                Value = 3,
                Description = "Reject",
                Text = "Do not provide the information and do not tell the guest lecturer where to get it as I deem it to be sensitive information.",
            },
            new EvalResponse
            {
                Id = 36,
                ScenarioId = 9,
                Value = 4,
                Description = "Accept",
                Text = "Provide all the requested information.",
            },


            // Scenario 10
            new EvalResponse
            {
                Id = 37,
                ScenarioId = 10,
                Value = 1,
                Description = "Ask to elaborate and decide later",
                Text = "I ask several complementary questions before I comply by clicking the download link.",
            },
            new EvalResponse
            {
                Id = 38,
                ScenarioId = 10,
                Value = 2,
                Description = "Ask to elaborate and request time to evaluate later",
                Text = "I ask complementary questions and ask if I can come back to him at a later stage.",
            },
            new EvalResponse
            {
                Id = 39,
                ScenarioId = 10,
                Value = 3,
                Description = "Reject",
                Text = "I do not comply with his request at all.",
                IsCorrect = true,
            },
            new EvalResponse
            {
                Id = 40,
                ScenarioId = 10,
                Value = 4,
                Description = "Accept",
                Text = "I instantly comply and follow the new download link.",
            },
        };

        #endregion
    }
}
