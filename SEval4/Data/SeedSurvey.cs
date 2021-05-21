using SEval4.Models;
using System.Collections.Generic;

namespace SEval4.Data
{
    public static class SeedSurvey
    {
        public static readonly StudyGroup[] StudyGroupsSeed =
        {
            new StudyGroup
            {
                Id = 1,
                Name = "SEADM",
            },
            new StudyGroup
            {
                Id = 2,
                Name = "Feedback",
            }
        };

        public static readonly AgeGroup[] AgeGroupsSeed = 
        {
            new AgeGroup
            {
                // Id = 1,
                Text = "18 - 24 years old",
                Value = 1,
            },
            new AgeGroup
            {
                // Id = 2,
                Text = "25 - 34 years old",
                Value = 2,
            },
            new AgeGroup
            {
                // Id = 3,
                Text = "35 - 44 years old",
                Value = 3,
            },
            new AgeGroup
            {
                // Id = 4,
                Text = "45 - 54 years old",
                Value = 4,
            },
            new AgeGroup
            {
                // Id = 5,
                Text = "55 - 64 years old",
                Value = 5,
            },
            new AgeGroup
            {
                // Id = 6,
                Text = "65+ years old",
                Value = 6,
            },
        };

        public static readonly YearGroup[] YearGroupsSeed = 
        {
            new YearGroup
            {
                // Id = 1,
                Text = "1 year or less",
                Value = 1,
            },
            new YearGroup
            {
                // Id = 2,
                Text = "2 - 3 years",
                Value = 2,
            },
            new YearGroup
            {
                // Id = 3,
                Text = "4 - 5 years",
                Value = 3,
            },
            new YearGroup
            {
                // Id = 4,
                Text = "6 years or more",
                Value = 4,
            },
        };

        public static readonly EducationGroup[] EducationGroupsSeed = 
        {
            new EducationGroup
            {
                // Id = 1,
                Text = "Primary Education",
                Value = 1,
            },
            new EducationGroup
            {
                // Id = 2,
                Text = "Secondary Education",
                Value = 2,
            },
            new EducationGroup
            {
                // Id = 3,
                Text = "Vocational training",
                Value = 3,
            },
            new EducationGroup
            {
                // Id = 4,
                Text = "Bachelor degree or equivalent",
                Value = 4,
            },
            new EducationGroup
            {
                // Id = 5,
                Text = "Postgraduate Master",
                Value = 5,
            },
            new EducationGroup
            {
                // Id = 6,
                Text = "PhD",
                Value = 6,
            },
        };

        public static readonly ConfidenceGroup[] ConfidenceGroupsSeed = 
        {
            new ConfidenceGroup
            {
                // Id = 1,
                Text = "No confidence",
                Value = 1,
            },
            new ConfidenceGroup
            {
                // Id = 2,
                Text = "Low confidence",
                Value = 2,
            },
            new ConfidenceGroup
            {
                // Id = 3,
                Text = "Moderate confidence",
                Value = 3,
            },
            new ConfidenceGroup
            {
                // Id = 4,
                Text = "High confidence",
                Value = 4,
            },
            new ConfidenceGroup
            {
                // Id = 5,
                Text = "Full confidence",
                Value = 5,
            },

        };

        public static readonly Scenario[] ScenariosSeed =
        {
            new Scenario
            {
                Context = "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is very sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what user-name you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?",
                ScenarioId = 1,
            },
            new Scenario
            {
                Context = "You are a Computer Science Honours student at UCT, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have a big network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in Cape Town. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position as of yet post studies? I’d be keen to have a chat with you to find out what It is that really interests you so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?",
                ScenarioId = 2,
            },
            new Scenario
            {
                Context = "It is snowy outside, and you are enjoying your Christmas vacation that is longer than you have had in some time. This is going to be a much needed vacation. You have been extra careful ensuring that your tasks at work have been divided among colleagues, so that everyone knows who is responsible for what while you are on vacation. You have also informed your most important customer, and he has, with the usual protests, accepted your vacation. You have just poured a glass of mulled wine when the phone rings. You curse your forgetfulness about leaving the phone on before answering. A very apologetic woman presents herself as a newly employed technician of your customer. She tells you that she is very sorry for calling you, but because she is going to upgrade the customer's backup system she needs to know where the files you have worked on can be found. She also wants to know which computer they are located in and what folder, as well as what user-name you have, in order to guarantee that they will be backed up in the new system. You give her this information, and she thanks you and wishes you a Merry Christmas. An hour later she calls again, almost ready to cry. Something has gone wrong with your backup, she suspects, as it has been locked in the system, and she is the only one left over Christmas. It also seems that only your files are causing trouble. She asks if you would consider coming into the customer's office, checking this, something you refuse. She then wonders if you can give her your login information to enable her to quickly check that the files have not been destroyed so that you can both celebrate Christmas in peace. Which action do you take?",
                ScenarioId = 3,
                Feedback = "Placeholder feedback 1",
            },
            new Scenario
            {
                Context = "You are a Computer Science Honours student at UCT, currently searching for a job. You receive an invite from someone, who you have never met before, on LinkedIn. You have heard that it is a good idea to have a big network on LinkedIn, so you decide to accept the person’s invite. The following day you receive an email from the person you accepted on LinkedIn. The email contains the following message: “Hey, Thanks for connecting with me on LinkedIn. I specialise in placing Software Engineers in Cape Town. I see on your LinkedIn profile that you are currently doing your Computer Science Honours at UCT. When will you be finishing off there? Have you managed to secure a position as of yet post studies? I’d be keen to have a chat with you to find out what It is that really interests you so I know what to keep my eyes peeled for. Would you be keen? Look forward to hearing from you.” The signature of the email contains the recruiter’s full name, his mobile and landline numbers as well as links to his recruitment company’s website and social media accounts. What action do you take?",
                ScenarioId = 4,
                Feedback = "Placeholder feedback 2",
            }
        };

        public static readonly Response[] ResponsesSeed =
        {
            // Scenario 1
            new Response
            {
                ScenarioId = 1,
                ResponseOrder = 1,
                Description = "Refuse immidately",
                Text = "Refuse to help her entirely and hang up the phone.",
                Value = 1,
            },
            new Response
            {
                ScenarioId = 1,
                ResponseOrder = 2,
                Description = "Refer to colleague",
                Text = "Ask her to contact one of your colleagues since you are on holiday.",
                Value = 2,
            },
            new Response
            {
                ScenarioId = 1,
                ResponseOrder = 3,
                Description = "Accept immediately",
                Text = "Instantly provide her with your login details and wish her a merry Christmas.",
                Value = 3,
            },
            new Response
            {
                ScenarioId = 1,
                ResponseOrder = 4,
                Description = "Ask more questions and decide later",
                Text = "Ask her a few complementary questions and based on her answers either provide her with your login details or don’t provide her with any information.",
                Value = 4,
            },

            // Scenario 2
            new Response
            {
                ScenarioId = 2,
                ResponseOrder = 1,
                Description = "Click on the links and decide later",
                Text = "Click on the links provided, and have a look at the company’s online profile as well as reviews left by others. If all seems good, get in contact with the recruiter.",
                Value = 1,
            },
            new Response
            {
                ScenarioId = 2,
                ResponseOrder = 2,
                Description = "Accept immediately and provide too much data",
                Text = "You have been job hunting for ages and see this as a blessing in disguise. You reply to the email saying that you would appreciate his help and attach a copy of your CV, a copy of your ID and a link to your GitHub account. (Since you know he will most likely request all this information anyway.",
                Value = 2,
            },
            new Response
            {
                ScenarioId = 2,
                ResponseOrder = 3,
                Description = "Ignore and block",
                Text = "Ignore the email and remove the recruiter from your LinkedIn.",
                Value = 3,
            },
            new Response
            {
                ScenarioId = 2,
                ResponseOrder = 4,
                Description = "Use the number to arrange a meeting",
                Text = "Give the recruiter a call on one of the two numbers provided and arrange to meet up with him to discuss how he can help you.",
                Value = 4,
            },
            // Scenario 1
            new Response
            {
                ScenarioId = 3,
                ResponseOrder = 1,
                Description = "Refuse immidately",
                Text = "Refuse to help her entirely and hang up the phone.",
                Value = 1,
                IsCorrect = true,
            },
            new Response
            {
                ScenarioId = 3,
                ResponseOrder = 2,
                Description = "Refer to colleague",
                Text = "Ask her to contact one of your colleagues since you are on holiday.",
                Value = 2,
            },
            new Response
            {
                ScenarioId = 3,
                ResponseOrder = 3,
                Description = "Accept immediately",
                Text = "Instantly provide her with your login details and wish her a merry Christmas.",
                Value = 3,
            },
            new Response
            {
                ScenarioId = 3,
                ResponseOrder = 4,
                Description = "Ask more questions and decide later",
                Text = "Ask her a few complementary questions and based on her answers either provide her with your login details or don’t provide her with any information.",
                Value = 4,
            },

            // Scenario 2
            new Response
            {
                ScenarioId = 4,
                ResponseOrder = 1,
                Description = "Click on the links and decide later",
                Text = "Click on the links provided, and have a look at the company’s online profile as well as reviews left by others. If all seems good, get in contact with the recruiter.",
                Value = 1,
            },
            new Response
            {
                ScenarioId = 4,
                ResponseOrder = 2,
                Description = "Accept immediately and provide too much data",
                Text = "You have been job hunting for ages and see this as a blessing in disguise. You reply to the email saying that you would appreciate his help and attach a copy of your CV, a copy of your ID and a link to your GitHub account. (Since you know he will most likely request all this information anyway.",
                Value = 2,
            },
            new Response
            {
                ScenarioId = 4,
                ResponseOrder = 3,
                Description = "Ignore and block",
                Text = "Ignore the email and remove the recruiter from your LinkedIn.",
                Value = 3,
            },
            new Response
            {
                ScenarioId = 4,
                ResponseOrder = 4,
                Description = "Use the number to arrange a meeting",
                Text = "Give the recruiter a call on one of the two numbers provided and arrange to meet up with him to discuss how he can help you.",
                Value = 4,
                IsCorrect = true,
            },
        };
    }
}
