using System;
using System.Collections.Generic;
using System.Linq;

namespace TestingGrounds.SEADM.Models
{
    class SeadmState
    {
        #region Member variables

        public string StateId { get; private set; }
        public StateTypeEnum StateType { get; private set; }
        public string PreviousStateId { get; set; }

        // Questions
        protected List<SeadmQuestion> Questions { get; private set; }
        public int QuestionCount => Questions?.Count ?? 0;
        public int QuestionIndex { get; private set; }

        // Answers
        protected List<bool> Answers { get; private set; }
        public int YesCount => Answers?.Count(a => a) ?? 0;

        #endregion

        #region Public methods

        public SeadmState(string stateId, StateTypeEnum stateType = StateTypeEnum.Regular)
        {
            StateId   = stateId;
            StateType = stateType;

            Questions = QuestionsSource
                .Where(q => q.StateId == stateId)
                .ToList();
            Answers = new List<bool>(new bool[QuestionCount]);
            
            QuestionIndex = 0;
        }

        public string GetCurrentQuestion() =>
            Questions[QuestionIndex].Text;

        public bool NextQuestion(bool value)
        {
            Answers[QuestionIndex] = value;
            if (QuestionCount - QuestionIndex == 1)
            {
                return true;
            }
            else
            {
                QuestionIndex++;
                return false;
            }
        }

        public bool PreviousQuestion()
        {
            if (QuestionIndex == 0)
            {
                return true;
            }
            else
            {
                QuestionIndex--;
                return false;
            }
        }

        public void Reset()
        {
            QuestionIndex = 0;
            PreviousStateId = string.Empty;

            for (int i = 0; 
                i < Answers.Count; 
                Answers[i++] = false);
        }

        public void PrintInfo()
        {
            string type = StateType switch
            {
                StateTypeEnum.Starting => "starting",
                StateTypeEnum.Terminal => "terminal",
                _ => "regular",
            };

            Console.WriteLine($"State {StateId} => {type} state with {QuestionCount} questions.");

            for (int i = 0; i < Questions.Count; i++)
            {
                Console.WriteLine($"\t{i+1} {Questions[i].Text}");
            }

            Console.WriteLine("\n");
        }

        #endregion

        #region Data

        public static readonly List<SeadmQuestion> QuestionsSource = new()
        {
            new SeadmQuestion
            {
                StateId = "SA",
                Text = "Accept",
            },
            new SeadmQuestion
            {
                StateId = "SR",
                Text = "Reject",
            },
            new SeadmQuestion
            {
                StateId = "SE",
                Text = "Elaborate",
            },
            new SeadmQuestion
            {
                StateId = "S1",
                Text = "Do you understand what is requested?",
            },
            new SeadmQuestion
            {
                StateId = "S2",
                Text = "Can you ask the requester to elaborate further on the request?",
            },
            new SeadmQuestion
            {
                StateId = "S3",
                Text = "Do you understand how to perform the request?",
            },
            new SeadmQuestion
            {
                StateId = "S4",
                Text = "Are you capable of performing the request?",
            },
            new SeadmQuestion
            {
                StateId = "S5",
                Text = "Do you have the authority to perform the request?",
            },
            new SeadmQuestion
            {
                StateId = "S6",
                Text = "Is the requested action or information avaiable to the public?",
            },
            new SeadmQuestion
            {
                StateId = "S7",
                Text = "Is this a pre-approved request that can be perofrmed to avoid a life-threatening emergency?",
            },
            new SeadmQuestion
            {
                StateId = "S8",
                Text = "Are there any administrative reasons for refusal?",
            },
            new SeadmQuestion
            {
                StateId = "S9",
                Text = "Are there any procedural reasons for refusal?",
            },
            new SeadmQuestion
            {
                StateId = "S10",
                Text = "Is this a new or an unusual type of request?",
            },
            new SeadmQuestion
            {
                StateId = "S11",
                Text = "Are there any other reasons for refusal?",
            },
            new SeadmQuestion
            {
                StateId = "S12",
                Text = "Is the requester's identity verifiable?",
            },
            new SeadmQuestion
            {
                StateId = "S13",
                Text = "Can the authority level of the requester be verified?",
            },
            new SeadmQuestion
            {
                StateId = "S13",
                Text = "Can the credibility of the requester be verified?",
            },
            new SeadmQuestion
            {
                StateId = "S13",
                Text = "Did you have previous interaction with the requester?",
            },
            new SeadmQuestion
            {
                StateId = "S13",
                Text = "Are you aware of the existence of the requester?",
            },
            new SeadmQuestion
            {
                StateId = "S14",
                Text = "Can you verify the requester through a third party source?",
            },
            new SeadmQuestion
            {
                StateId = "S15",
                Text = "Does the verification process reflect the same information as verification requirements?",
            },
            new SeadmQuestion
            {
                StateId = "S16",
                Text = "Does the requester have the necessary authority to request the action or the information?",
            },
        };

        #endregion
    }
}
