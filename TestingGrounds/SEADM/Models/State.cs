using System;
using System.Collections.Generic;
using System.Linq;

namespace TestingGrounds.SEADM.Models
{
    class State
    {
        #region Member variables

        public string StateId { get; private set; }
        public StateTypeEnum StateType { get; private set; }
        public string PreviousStateId { get; private set; }

        // Questions
        protected List<Question> Questions { get; private set; }
        public int QuestionCount => Questions?.Count ?? 0;
        public int QuestionIndex { get; private set; }

        // Answers
        protected List<bool> Answers { get; private set; }
        public int YesCount => Answers?.Count(a => a) ?? 0;

        #endregion

        #region Public methods

        public State(string stateId, StateTypeEnum stateType = StateTypeEnum.Regular)
        {
            StateId   = stateId;
            StateType = stateType;

            Questions = QuestionsSource
                .Where(q => q.StateId == stateId)
                .ToList();
            Answers = new List<bool>(QuestionCount);
            
            QuestionIndex = 0;
            PreviousStateId = string.Empty;
        }

        public void Reset()
        {
            QuestionIndex = 0;
            PreviousStateId = string.Empty;

            for (int i = 0; 
                i < Answers.Count; 
                Answers[i++] = false);
        }
        #endregion



        public static readonly List<Question> QuestionsSource = new()
        {
            new Question
            {
                StateId = "SA",
                Text = "Accept",
            },
            new Question
            {
                StateId = "SR",
                Text = "Reject",
            },
            new Question
            {
                StateId = "SE",
                Text = "Elaborate",
            },
            new Question
            {
                StateId = "S1",
                Text = "Do you understand what is requested?",
            },
            new Question
            {
                StateId = "S2",
                Text = "Can you ask the requester to elaborate further on the request?",
            },
            new Question
            {
                StateId = "S3",
                Text = "Do you understand how to perform the request?",
            },
            new Question
            {
                StateId = "S4",
                Text = "Are you capable of performing the request?",
            },
            new Question
            {
                StateId = "S5",
                Text = "Do you have the authority to perform the request?",
            },
            new Question
            {
                StateId = "S6",
                Text = "Is the requested action or information avaiable to the public?",
            },
            new Question
            {
                StateId = "S7",
                Text = "Is this a pre-approved request that can be perofrmed to avoid a life-threatening emergency?",
            },
            new Question
            {
                StateId = "S8",
                Text = "Are there any administrative reasons for refusal?",
            },
            new Question
            {
                StateId = "S9",
                Text = "Are there any procedural reasons for refusal?",
            },
            new Question
            {
                StateId = "S10",
                Text = "Is this a new or an unusual type of request?",
            },
            new Question
            {
                StateId = "S11",
                Text = "Are there any other reasons for refusal?",
            },
            new Question
            {
                StateId = "S12",
                Text = "Is the requester's identity verifiable?",
            },
            new Question
            {
                StateId = "S13",
                Text = "Can the authority level of the requester be verified?",
            },
            new Question
            {
                StateId = "S13",
                Text = "Can the credibility of the requester be verified?",
            },
            new Question
            {
                StateId = "S13",
                Text = "Did you have previous interaction with the requester?",
            },
            new Question
            {
                StateId = "S13",
                Text = "Are you aware of the existence of the requester?",
            },
            new Question
            {
                StateId = "S14",
                Text = "Can you verify the requester through a third party source?",
            },
            new Question
            {
                StateId = "S15",
                Text = "Does the verification process reflect the same information as verification requirements?",
            },
            new Question
            {
                StateId = "S16",
                Text = "Does the requester have the necessary authority to request the action or the information?",
            },
        };
    }
}
