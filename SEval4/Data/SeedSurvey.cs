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
                Context = "You are an administrator in the university Student Registry and you have been working on a particularly monotonous task for the past couple hours. The phone on  your desk rings breaking your focus. You answer the phone and as the caller introduces themselves you see that the call is incoming from the neighbouring country. \"I'm a taxi driver and I found a wallet belonging to a tourist I picked up from the airport. It contains £600 in cash, some banking cards, and a student ID card. Your number was on the back of the card. The company I work for didn't receive any calls about a lost wallet, but I feel really bad for that poor tourist, so I called you hoping you might give me their phone number so I can let them know I have it and  I can return it.\" The caller tells you the student's name and ID number which match in the student records.",
                Feedback = "The requested information is the student's phone number to which you have access as a member of the Registry staff. However, sharing students' personal and identifiable information would be a breach of their privacy. Furthermore, contacts provided by the caller cannot be considered a credible third party verifiers. Additionally, the request should not be ignored, as this may put the student in harm's way and expose university to a breach.",
            },
            new EvalScenario
            {
                Id = 2,
                Context = "It is late evening and you are relaxing at home after a long day at work when your phone rings. You pick up and the caller introduces himself as a policeman, giving you their name and rank. They also tell you that the topics discussed during this call will be confidential and telling anyone about it is a criminal offence. The police is running a discrete investigation on one of the employees in your company and want to ask you about their office hours, any upcoming holidays they are planning to take, and other helpful information such as location of their office in the building and all contact details to the employee. All of these are accessible to you through the company management website.",
                Feedback = "The caller is requesting information on the employee's timetable and contact information which you are capable of providing by logging into the company website, however, you are not authorised to communicate company's internal business to the law enforcement. The requested information may be used to plan an unlawful entry into the company building or even to target the employee. Additionally, police cannot legally request confidentiality without appropriate paper work. This may be a social engineering attempt not get exposed.",
            },
            new EvalScenario
            {
                Id = 3,
                Context = "It is evening and you are finishing an assessment in a classroom on campus where you are allowed to study until 10 pm. You submit your assessment 15 minutes before the deadline and triumphantly leave the building when you hear someone calling your name. You see your friend, who is taking the same classes, out of breath and visibly stressed out. He tells you that internet at his flat stopped working and he ran all the way to the campus to submit his finished assessment, but from the stress, he forgot the student ID which must be swiped to open the door. He asks you to let him into the building. You note that, if needed, security can still verify the student's identity with just their name and ID number, and it's not against the rules for multiple students or employees to enter with a single swipe.",
                Feedback = "The requested action is to grant access to the building for your fellow student without an ID. Since you know them personally, you can confirm they are doing the same assessment and would normally have access to the building now. Considering no rules against opening the door for authorised people, you let him in. Note however, that you may be held accountable if the student stays too long or commits a nefarious deed in the building.",
            },
            new EvalScenario
            {
                Id = 4,
                Context = "It has been almost half a year since you began working in this company and you are soon you will be eligible for employee benefits like health insurance and a pension scheme enrolment. You receive an e-mail from an external address informing you that you will be soon enrolled into a pension scheme. You must provide your staff ID, National Insurance Number, date of birth, place of residence, and some other personal data. The e-mail is well written and the sender mentions they work for a company hired by your employer to handle pensions and wages. The signature of the e-mail contains a phone number and links to the company websites. The website matches the domain of the sender's e-mail address.",
                Feedback = "The requested information are your own personal identifiable data which means you don't need authorisation to share them. Since the request is unusual, coming from an address and company unknown to you, the sender's credibility and authority to collect these data should be verified with a third party that you are familiar with and trust.",
            },
            new EvalScenario
            {
                Id = 5,
                Context = "You work as a programmer in a clinical trials unit of university, developing tools and websites for the trials, and managing their databases. You receive a phone call from an unknown external number. The caller introduces themself as a nurse in a practice where one of trials takes place. They tell you that one of the drugs was found to cause severe adverse effects in one participant, and all participants taking this drug must be contacted immediately to stop the treatment and come for examination. However, the internet and phoneline in the practice are malfunctioning and they cannot load the trial website where this can be done or call with the landline. They ask if you can do it as soon as possible. You tell the nurse that, being a programmer, you are not authorised to intervene in the trials but she insists that it may be a life-threatening situation.",
                Feedback = "The action requested is to send a bulk message to cease the trial of a research drug and prevent life-threatening situation. Although you know how to perform the request and it could prevent an serious emergency, doing so would be a security breach as you are not sufficiently authorised. Furthermore, the credibility of the nurse's claims and her authority are difficult to verify having only their phone number and data they provided. A malicious agent may have acquired the nurse's identifiable data in a separate attack and impersonated them to disrupt the trial.",
            },
            new EvalScenario
            {
                Id = 6,
                Context = "Your first year of university is coming to an end and you are looking for a summer internship to get some experience in the field you study. Following a friend's advice, you have had set up a LinkedIn account and have been expanding your social network for weeks. This morning you received an e-mail from an unknown Gmail address to your student e-mail: \"Good afternoon, I am a recruiter for a new start-up and I am looking for students interested in a highly paid summer placement. I found your profile on LinkedIn really impressive and I would like to invite you to apply. Considering the salary of the position, we decided to reach out to the most promising students directly. Be aware that while the offer is exclusive, the number of placements is limited and you should apply as soon as possible. Below you will find the job description and a link to the online application form.\" The description highlights the surprisingly high salary for entry level requirements. You note that the company name is not mentioned in the e-mail apart for the domain name of the link, and the signature contains no alternative means of contact.",
                Feedback = "In this scenario, the requested action is to click the link and fill a form to apply for a job. The e-mail is unprofessional, using a Gmail account, sending links to unknown websites, and having no alternative means of contact. It would be very difficult to verify credibility of the sender and clicking on random links is dangerous with or without the browser Private mode. Additionally, if the sender is malicious, they can impersonate a real recruiter on LinkedIn to attempt to convince you.",
            },
            new EvalScenario
            {
                Id = 7,
                Context = "You work as a client support consultant for a bank. Yesterday you received a call from a person claiming to be one of the known VIP clients. They said that they lost access to their account, but they failed to answer the verification questions. Despite the client's threats to get you fired, you decided to follow the procedures and refuse the service. Your phone rings and you pick up, but before you manage to introduce yourself, an angry voice interrupts you claiming to be the CEO of the bank. \"I can't believe I have to interrupt my holiday and call from the middle of nowhere for this\" he shouts as he scolds you for disrespecting the VIP. \"You will call them immediately and provide them with anything they want, am I understood?!\", he concludes and hangs up before you manage to answer. The number your boss called from is external looks like a regular mobile phone number. Since it is a huge bank, you have never met or talked to the CEO before.",
                Feedback = "In this scenario your boss requests you to ignore the security protocol and provide the client with the access they requested. The CEO is probably the only person in the whole company who can authorise you to do that. However, given no previous interaction and unknown number he called from, it is difficult to verify their credibility and authority. A malicious agent may pretend to be a person with authority, like CEO, to pressure you into performing their requests.",
            },
            new EvalScenario
            {
                Id = 8,
                Context = "You work in a small organisation with five other employees. Because of its size, you rotate who is in charge of social media, rather than having a dedicated staff for it, and this week it is your turn. You see that all incoming messages are questions about your services apart for one which reads: \"Hi, I am a student in a local school where I also work for our school magazine. I attended one of your charity events two weeks ago and I would like to ask the organiser for an interview about organising charity events. You will find the list of questions I would like to ask in the attached pdf. I tried to reach you through the press e-mail address, but received no response. Please let me know if there is another address I should use to request an interview. Kind Regards\". You notice that the press e-mail on the social media page has not been updated since the organisation changed it a month ago but you quickly fix that mistake.",
                Feedback = "The requested information here is an alternative means of journalist contact. Since the e-mail address should normally be available on the social media page, it is publicly available and can be provided to the student. With that, verifying the student's identity is unnecessary. Although the student seems to be genuine, pdf files from unverified sources should still be distrusted.",
            },
        };

        public static readonly EvalResponse[] EvalResponsesSeed =
        {
            // Scenario 1
            new EvalResponse
            {
                Id = 1,
                ScenarioId = 1,
                Value = 1,
                Description = "N/A",
                Text = "You provide the caller with the student's phone number and send an e-mail to the student to let them know the taxi driver called you and will get in touch with them soon.",
                IsCorrect = false,
            },
            new EvalResponse
            {
                Id = 2,
                ScenarioId = 1,
                Value = 2,
                Description = "N/A",
                Text = "You refuse to provide the contact details, hang up, and return to your regular tasks.",
                IsCorrect = false,
            },
            new EvalResponse
            {
                Id = 3,
                ScenarioId = 1,
                Value = 3,
                Description = "N/A",
                Text = "You refuse to provide the phone number. Instead, you request the driver to hand the wallet to the local police department and e-mail the student to tell them about the wallet and to contact the police.",
                IsCorrect = true,
            },
            new EvalResponse
            {
                Id = 4,
                ScenarioId = 1,
                Value = 4,
                Description = "N/A",
                Text = "Ask the caller what company they work for so you can call them and verify the caller's identity as their employee.",
                IsCorrect = false,
            },
            // Scenario 2
            new EvalResponse
            {
                Id = 5,
                ScenarioId = 2,
                Value = 1,
                Description = "N/A",
                Text = "Provide the caller with any information they need to aid the investigation and keep the call a secret.",
                IsCorrect = false,
            },
            new EvalResponse
            {
                Id = 6,
                ScenarioId = 2,
                Value = 2,
                Description = "N/A",
                Text = "You tell the caller you cannot help them as you are out of office right now. You tell them your office hours tomorrow so they can call you there.",
                IsCorrect = false,
            },
            new EvalResponse
            {
                Id = 7,
                ScenarioId = 2,
                Value = 3,
                Description = "N/A",
                Text = "Refuse to provide the caller with any information and advise them to contact the company department authorized to handle such requests. You also notify the company security of the potential police impostors.",
                IsCorrect = true,
            },
            new EvalResponse
            {
                Id = 8,
                ScenarioId = 2,
                Value = 4,
                Description = "N/A",
                Text = "Refuse to provide the caller with any information and advise them to contact the company department authorized to handle such requests. Following their warning, you keep the call and its contents confidential.",
                IsCorrect = false,
            },
            // Scenario 3
            new EvalResponse
            {
                Id = 9,
                ScenarioId = 3,
                Value = 1,
                Description = "N/A",
                Text = "You tell the your classmates that you cannot let them in and they should seek assistance from the security.",
                IsCorrect = false,
            },
            new EvalResponse
            {
                Id = 10,
                ScenarioId = 3,
                Value = 2,
                Description = "N/A",
                Text = "You let your classmate into the building, but only if you can accompany him the entire time and you will leave the building together.",
                IsCorrect = true,
            },
            new EvalResponse
            {
                Id = 11,
                ScenarioId = 3,
                Value = 3,
                Description = "N/A",
                Text = "You let the student in, and after wishing the good luck, you head home.",
                IsCorrect = false,
            },
            new EvalResponse
            {
                Id = 12,
                ScenarioId = 3,
                Value = 4,
                Description = "N/A",
                Text = "You refuse to help the student and go home.",
                IsCorrect = false,
            },
            // Scenario 4
            new EvalResponse
            {
                Id = 13,
                ScenarioId = 4,
                Value = 1,
                Description = "N/A",
                Text = "You check the company website to verify their legitimacy and provide the agent with all the information they need.",
                IsCorrect = false,
            },
            new EvalResponse
            {
                Id = 14,
                ScenarioId = 4,
                Value = 2,
                Description = "N/A",
                Text = "You contact your company's HR department to notify them of the e-mail and verify the legitimacy of the sender. Based on what they say, provide the agent with the requested data or refuse.",
                IsCorrect = true,
            },
            new EvalResponse
            {
                Id = 15,
                ScenarioId = 4,
                Value = 3,
                Description = "N/A",
                Text = "You forward the e-mail to the security department, informing them of malicious spam, and ignore the request.",
                IsCorrect = false,
            },
            new EvalResponse
            {
                Id = 16,
                ScenarioId = 4,
                Value = 4,
                Description = "N/A",
                Text = "You call the agent's number, found in their signature, to ask more questions and decide whether to provide the data based on the agent's responses.",
                IsCorrect = false,
            },
            // Scenario 5
            new EvalResponse
            {
                Id = 17,
                ScenarioId = 5,
                Value = 1,
                Description = "N/A",
                Text = "You tell the nurse that your staff account is not authorised to access the website, but if they give you the password to their account, you can log in and perform the request on their behalf.",
                IsCorrect = false,
            },
            new EvalResponse
            {
                Id = 18,
                ScenarioId = 5,
                Value = 2,
                Description = "N/A",
                Text = "You refuse to perform the requested action and hang up.",
                IsCorrect = false,
            },
            new EvalResponse
            {
                Id = 19,
                ScenarioId = 5,
                Value = 3,
                Description = "N/A",
                Text = "You provide the caller with a number to the trial manager who is qualified to handle this type of requests.",
                IsCorrect = true,
            },
            new EvalResponse
            {
                Id = 20,
                ScenarioId = 5,
                Value = 4,
                Description = "N/A",
                Text = "Using your access to the database, you assign yourself the necessary permissions to enter the website and perform the request. With the emergency resolved, you remove the permissions and notify the nurse of the crisis averted.",
                IsCorrect = false,
            },
            // Scenario 6
            new EvalResponse
            {
                Id = 21,
                ScenarioId = 6,
                Value = 1,
                Description = "N/A",
                Text = "You decide to report the e-mail to the university IT support as spam and remove it from your inbox.",
                IsCorrect = true,
            },
            new EvalResponse
            {
                Id = 22,
                ScenarioId = 6,
                Value = 2,
                Description = "N/A",
                Text = "You knew that working hard and getting good grades in first year will reward you somehow. You lose no time to apply for the position to increase your chance of getting the position.",
                IsCorrect = false,
            },
            new EvalResponse
            {
                Id = 23,
                ScenarioId = 6,
                Value = 3,
                Description = "N/A",
                Text = "You tell the recruiter about your suspicions and ask them to contact you on LinkedIn where you can see more information about them.",
                IsCorrect = false,
            },
            new EvalResponse
            {
                Id = 24,
                ScenarioId = 6,
                Value = 4,
                Description = "N/A",
                Text = "You open the link using a Private (or Incognito) mode of your web browser as a protective measure. If the website seems fine, apply for the position.",
                IsCorrect = false,
            },
            // Scenario 7
            new EvalResponse
            {
                Id = 25,
                ScenarioId = 7,
                Value = 1,
                Description = "N/A",
                Text = "Following the call, you immediately call the number the VIP called from yesterday. You help them regain access and ask them for new verification questions.",
                IsCorrect = false,
            },
            new EvalResponse
            {
                Id = 26,
                ScenarioId = 7,
                Value = 2,
                Description = "N/A",
                Text = "You ignore the caller's request and report the number he called from to the security. You are sure your boss would not ask you to ignore important security features.",
                IsCorrect = false,
            },
            new EvalResponse
            {
                Id = 27,
                ScenarioId = 7,
                Value = 3,
                Description = "N/A",
                Text = "Before you do anything, you call your management to verify the number belongs to the CEO. With their response you decide whether to perform the request or report the number to the security.",
                IsCorrect = true,
            },
            new EvalResponse
            {
                Id = 28,
                ScenarioId = 7,
                Value = 4,
                Description = "N/A",
                Text = "You call your boss back and ask some questions about the client to verify their identity as an alternative to verification questions they forgot.",
                IsCorrect = false,
            },
            // Scenario 8
            new EvalResponse
            {
                Id = 29,
                ScenarioId = 8,
                Value = 1,
                Description = "N/A",
                Text = "You send the corrected e-mail address to the student and let them know about the previous address being incorrect.",
                IsCorrect = true,
            },
            new EvalResponse
            {
                Id = 30,
                ScenarioId = 8,
                Value = 2,
                Description = "N/A",
                Text = "To make up for the mistake, you decide to forward the file with questions to the employee who organised the event and tell them about the student and the e-mail mistake. You ask them to look at the questions and answer them when they have a spare moment.",
                IsCorrect = false,
            },
            new EvalResponse
            {
                Id = 31,
                ScenarioId = 8,
                Value = 3,
                Description = "N/A",
                Text = "You mark the message as spam, report the sender, and warn your colleagues about scammers on social media inbox.",
                IsCorrect = false,
            },
            new EvalResponse
            {
                Id = 32,
                ScenarioId = 8,
                Value = 4,
                Description = "N/A",
                Text = "Call the school the student is studying in to verify his identity and authority as a school journalist. If the sender is telling truth, provide them with the corrected e-mail address. Otherwise, mark the message as spam, report sender, and warn your colleagues about a scammer.",
                IsCorrect = false,
            },
        };

        #endregion
    }
}
