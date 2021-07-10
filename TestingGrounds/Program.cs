using System;
using System.Collections.Generic;
using TestingGrounds.SEADM.Models;

namespace TestingGrounds
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildData();
            TestSeadmAutomata();
        }

        private static void BuildData()
        {
            List<string> scenarios = new();
            List<string> responses = new();

            string strScenario = @"

            new EvalScenario
            {
                Id = {Id},
                Context = ""{Context}"",
                Feedback = ""{Feedback}"",
            },
";
            string strResponse = @"
            new EvalResponse
            {
                Id = {Id},
                ScenarioId = {ScenarioId},
                Value = {Value},
                Description = ""N/A"",
                Text = ""{Text}"",
                IsCorrect = {IsCorrect},
            },";

            int scenarioId, responseId = 1;
            string line, context, feedback, description, text;
            bool isCorrect;

            string[] lines = doc.Split("\r\n");
            int lineIndex = 0;
            while (lineIndex < lines.Length)
            {
                if (int.TryParse(lines[lineIndex], out scenarioId))
                {
                    // Jump to context
                    lineIndex += 3;
                    context = lines[lineIndex].Trim();

                    // Jump to responses
                    lineIndex += 2;

                    // Store responses
                    int responseValue = 1;
                    while (lines[lineIndex].Trim() != "Feedback")
                    {
                        line = lines[lineIndex++];

                        if (responseValue == 1)
                        {
                            responses.Add($"\r\n\t\t\t// Scenario {scenarioId}");
                        }

                        responses.Add(strResponse
                            .Replace("{Id}", responseId++.ToString())
                            .Replace("{ScenarioId}", scenarioId.ToString())
                            .Replace("{Text}", line.Replace(">", string.Empty).Trim())
                            .Replace("{Value}", responseValue++.ToString().Trim())
                            .Replace("{IsCorrect}", line.StartsWith('>') ? "true" : "false"));
                    }

                    // Jump to Feedback
                    lineIndex += 1;

                    feedback = lines[lineIndex].Trim();

                    scenarios.Add(strScenario
                        .Replace("{Id}", scenarioId.ToString())
                        .Replace("{Context}", context.Trim())
                        .Replace("{Feedback}", feedback.Trim())
                        );

                    lineIndex++;
                }
                else
                {
                    lineIndex++;
                }
            }

            responses.ForEach(r => Console.Out.Write(r));
            Console.Out.WriteLine("\r\n\r\n\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
            scenarios.ForEach(s => Console.Out.Write(s));
        }

        private static void TestSeadmAutomata()
        {
            SeadmAutomat fsa = new();

            string allowed = "ynbqr";
            ConsoleKeyInfo key;
            char input;
            while (true)
            {
                Console.WriteLine(fsa.GetQuestion());

                do
                {
                    Console.Write($"[{allowed}] >>> ");

                    // Allowing ReadKey to print the character
                    // results in corrupted Out buffer on next line.
                    // Therefore, skip Escape
                    key   = Console.ReadKey(true);
                    input = (key.Key == ConsoleKey.Escape)
                        ? '\0'
                        : key.KeyChar;

                    Console.WriteLine(input);
                } while (!allowed.Contains(input));

                switch (input)
                {
                    case 'y':
                        fsa.NextQuestion(true);
                        break;

                    case 'n':
                        fsa.NextQuestion(false);
                        break;

                    case 'b':
                        fsa.PreviousQuestion();
                        break;

                    case 'r':
                        fsa.Reset();
                        break;

                    case 'q':
                        Console.WriteLine("\nExiting the test...");
                        return;

                    default:
                        throw new Exception($"Recieved unexpected input: {input}.");
                }

                Console.Clear();
            }
        }

        static string doc = @"
1
Taxi driver found a student’s wallet in a different country and hopes to give it back (no authority)
Context
You are an administrator in the university Student Registry and you have been working on a particularly monotonous task for the past couple hours. The phone on  your desk rings breaking your focus. You answer the phone and as the caller introduces themselves you see that the call is incoming from the neighbouring country. “I’m a taxi driver and I found a wallet belonging to a tourist I picked up from the airport. It contains £600 in cash, some banking cards, and a student ID card. Your number was on the back of the card. The company I work for didn’t receive any calls about a lost wallet, but I feel really bad for that poor tourist, so I called you hoping you might give me their phone number so I can let them know I have it and  I can return it.” The caller tells you the student’s name and ID number which match in the student records.
Responses
You provide the caller with the student’s phone number and send an e-mail to the student to let them know the taxi driver called you and will get in touch with them soon. 
You refuse to provide the contact details, hang up, and return to your regular tasks. 
>You refuse to provide the phone number. Instead, you request the driver to hand the wallet to the local police department and e-mail the student to tell them about the wallet and to contact the police. 
Ask the caller what company they work for so you can call them and verify the caller’s identity as their employee. 
Feedback
The requested information is the student’s phone number to which you have access as a member of the Registry staff. However, sharing students’ personal and identifiable information would be a breach of their privacy. Furthermore, contacts provided by the caller cannot be considered a credible third party verifiers. Additionally, the request should not be ignored, as this may put the student in harm’s way and expose university to a breach. 
2
Police asking for employee’s information for secret investigation (no authority)
Context
It is late evening and you are relaxing at home after a long day at work when your phone rings. You pick up and the caller introduces himself as a policeman, giving you their name and rank. They also tell you that the topics discussed during this call will be confidential and telling anyone about it is a criminal offence. The police is running a discrete investigation on one of the employees in your company and want to ask you about their office hours, any upcoming holidays they are planning to take, and other helpful information such as location of their office in the building and all contact details to the employee. All of these are accessible to you through the company management website.
Responses
Provide the caller with any information they need to aid the investigation and keep the call a secret.
You tell the caller you cannot help them as you are out of office right now. You tell them your office hours tomorrow so they can call you there.
>Refuse to provide the caller with any information and advise them to contact the company department authorized to handle such requests. You also notify the company security of the potential police impostors.
Refuse to provide the caller with any information and advise them to contact the company department authorized to handle such requests. Following their warning, you keep the call and its contents confidential. 
Feedback
The caller is requesting information on the employee’s timetable and contact information which you are capable of providing by logging into the company website, however, you are not authorised to communicate company’s internal business to the law enforcement. The requested information may be used to plan an unlawful entry into the company building or even to target the employee. Additionally, police cannot legally request confidentiality without appropriate paper work. This may be a social engineering attempt not get exposed.
3
Student forgot ID and wants to be let into a building to submit an assessment before deadline (verifiable person) 
Context
It is evening and you are finishing an assessment in a classroom on campus where you are allowed to study until 10 pm. You submit your assessment 15 minutes before the deadline and triumphantly leave the building when you hear someone calling your name. You see your friend, who is taking the same classes, out of breath and visibly stressed out. He tells you that internet at his flat stopped working and he ran all the way to the campus to submit his finished assessment, but from the stress, he forgot the student ID which must be swiped to open the door. He asks you to let him into the building. You note that, if needed, security can still verify the student’s identity with just their name and ID number, and it’s not against the rules for multiple students or employees to enter with a single swipe.
Responses
You tell the your classmates that you cannot let them in and they should seek assistance from the security.
>You let your classmate into the building, but only if you can accompany him the entire time and you will leave the building together.
You let the student in, and after wishing the good luck, you head home.
You refuse to help the student and go home.
Feedback
The requested action is to grant access to the building for your fellow student without an ID. Since you know them personally, you can confirm they are doing the same assessment and would normally have access to the building now. Considering no rules against opening the door for authorised people, you let him in. Note however, that you may be held accountable if the student stays too long or commits a nefarious deed in the building. 
4
Pension scheme service representative asking for personal information (3rd party verification)
Context
It has been almost half a year since you began working in this company and you are soon you will be eligible for employee benefits like health insurance and a pension scheme enrolment. You receive an e-mail from an external address informing you that you will be soon enrolled into a pension scheme. You must provide your staff ID, National Insurance Number, date of birth, place of residence, and some other personal data. The e-mail is well written and the sender mentions they work for a company hired by your employer to handle pensions and wages. The signature of the e-mail contains a phone number and links to the company websites. The website matches the domain of the sender’s e-mail address.
Responses
You check the company website to verify their legitimacy and provide the agent with all the information they need.
>You contact your company’s HR department to notify them of the e-mail and verify the legitimacy of the sender. Based on what they say, provide the agent with the requested data or refuse.
You forward the e-mail to the security department, informing them of malicious spam, and ignore the request.
You call the agent’s number, found in their signature, to ask more questions and decide whether to provide the data based on the agent’s responses. 
Feedback
The requested information are your own personal identifiable data which means you don’t need authorisation to share them. Since the request is unusual, coming from an address and company unknown to you, the sender’s credibility and authority to collect these data should be verified with a third party that you are familiar with and trust. 
5
A nurse asks you to perform stop clinical trial drug test (no authority)
Context
You work as a programmer in a clinical trials unit of university, developing tools and websites for the trials, and managing their databases. You receive a phone call from an unknown external number. The caller introduces themself as a nurse in a practice where one of trials takes place. They tell you that one of the drugs was found to cause severe adverse effects in one participant, and all participants taking this drug must be contacted immediately to stop the treatment and come for examination. However, the internet and phoneline in the practice are malfunctioning and they cannot load the trial website where this can be done or call with the landline. They ask if you can do it as soon as possible. You tell the nurse that, being a programmer, you are not authorised to intervene in the trials but she insists that it may be a life-threatening situation. 
Responses
You tell the nurse that your staff account is not authorised to access the website, but if they give you the password to their account, you can log in and perform the request on their behalf.
You refuse to perform the requested action and hang up.
>You provide the caller with a number to the trial manager who is qualified to handle this type of requests.
Using your access to the database, you assign yourself the necessary permissions to enter the website and perform the request. With the emergency resolved, you remove the permissions and notify the nurse of the crisis averted.
Feedback
The action requested is to send a bulk message to cease the trial of a research drug and prevent life-threatening situation. Although you know how to perform the request and it could prevent an serious emergency, doing so would be a security breach as you are not sufficiently authorised. Furthermore, the credibility of the nurse’s claims and her authority are difficult to verify having only their phone number and data they provided. A malicious agent may have acquired the nurse’s identifiable data in a separate attack and impersonated them to disrupt the trial.
6
Suspicious e-mail offering high salary for an entry level position (no verification possible)
Context
Your first year of university is coming to an end and you are looking for a summer internship to get some experience in the field you study. Following a friend’s advice, you have had set up a LinkedIn account and have been expanding your social network for weeks. This morning you received an e-mail from an unknown Gmail address to your student e-mail: “Good afternoon, I am a recruiter for a new start-up and I am looking for students interested in a highly paid summer placement. I found your profile on LinkedIn really impressive and I would like to invite you to apply. Considering the salary of the position, we decided to reach out to the most promising students directly. Be aware that while the offer is exclusive, the number of placements is limited and you should apply as soon as possible. Below you will find the job description and a link to the online application form.“ The description highlights the surprisingly high salary for entry level requirements. You note that the company name is not mentioned in the e-mail apart for the domain name of the link, and the signature contains no alternative means of contact.
Responses
>You decide to report the e-mail to the university IT support as spam and remove it from your inbox.
You knew that working hard and getting good grades in first year will reward you somehow. You lose no time to apply for the position to increase your chance of getting the position.
You tell the recruiter about your suspicions and ask them to contact you on LinkedIn where you can see more information about them. 
You open the link using a Private (or Incognito) mode of your web browser as a protective measure. If the website seems fine, apply for the position.
Feedback
In this scenario, the requested action is to click the link and fill a form to apply for a job. The e-mail is unprofessional, using a Gmail account, sending links to unknown websites, and having no alternative means of contact. It would be very difficult to verify credibility of the sender and clicking on random links is dangerous with or without the browser Private mode. Additionally, if the sender is malicious, they can impersonate a real recruiter on LinkedIn to attempt to convince you. 
7
Your boss wants you to disregard security policy for an important client (3rd party verification)
Context
You work in as a client support consultant for a bank. Yesterday you received a call from a person claiming to be one of the known VIP clients, saying that they lost access to their account, but they failed to answer the verification questions correctly. Despite the client’s threats to to get you fired, you decided to follow the procedures and refuse the service. Today, as usual, your desk phone rings, but before you manage to introduce yourself, an angry voice interrupts you claiming to be the CEO of the bank. “I can’t believe I have to interrupt my holiday and call from the middle of nowhere for this” he shouts as he scolds you for disrespecting a VIP. “You will call them immediately and provide them with anything they want or you can pack your things, am I understood?!”, he concludes and hangs up before you manage to answer. The number your boss called from is external looks like a regular mobile phone number. Since it is a huge bank, you have never met or talked to the CEO before.
Responses
Following the call, you immediately call the number the VIP called from yesterday. You help them regain access and ask them for new verification questions.
You ignore the caller’s request and report the number he called from to the security. You are sure your boss would not ask you to ignore important security features.
>Before you do anything, you call your management to inform them of the call and ask to verify the number belongs to the CEO. With their response you decide whether to perform the request or report the number to the security.
You call your boss back and ask some questions about the client to verify their identity as an alternative to verification questions they forgot.
Feedback
In this scenario your boss requests you to ignore the security protocol and provide the client with the access they requested. The CEO is probably the only person in the whole company who can authorise you to do that. However, given no previous interaction and unknown number he called from, it is difficult to verify their credibility and authority. A malicious agent may pretend to be a person with authority, like CEO, to pressure you into performing their requests. 
8
School journalist requesting the public press e-mail address (publicly available information)
Context
You work in a small organisation with five other employees. Because of its size, you rotate who is in charge of social media, rather than having a dedicated staff for it, and this week it is your turn. You see that all incoming messages are questions about your services apart for one which reads: “Hi, I am a student in a local school where I also work for our school magazine. I attended one of your charity events two weeks ago and I would like to ask the organiser for an interview about organising charity events. You will find the list of questions I would like to ask in the attached pdf. I tried to reach you through the press e-mail address, but received no response. Please let me know if there is another address I should use to request an interview. Kind Regards”. You notice that the press e-mail on the social media page has not been updated since the organisation changed it a month ago but you quickly fix that mistake. 
Responses
>You send the corrected e-mail address to the student and let them know about the previous address being incorrect.
To make up for the mistake, you decide to forward the file with questions to the employee who organised the event and tell them about the student and the e-mail mistake. You ask them to look at the questions and answer them when they have a spare moment. 
You mark the message as spam, report the sender, and warn your colleagues about scammers on social media inbox.
Call the school the student is studying in to verify his identity and authority as a school journalist. If the sender is telling truth, provide them with the corrected e-mail address. Otherwise, mark the message as spam, report sender, and warn your colleagues about a scammer. 
Feedback
The requested information here is an alternative means of journalist contact. Since the e-mail address should normally be available on the social media page, it is publicly available and can be provided to the student. With that, verifying the student’s identity is unnecessary. Although the student seems to be genuine, pdf files from unverified sources should still be distrusted.
";
    }
}