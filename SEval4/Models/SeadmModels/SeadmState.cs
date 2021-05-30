using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4.Models.SeadmModels
{
    public class SeadmState
    {
        #region Member variables

        #region State

        public string StateId { get; private set; }
        public SeadmStateTypeEnum StateType { get; private set; }
        public string PreviousStateId { get; set; }

        #endregion

        #region Questions
        
        protected SeadmQuestion[] Questions { get; set; }
        public int QuestionCount => Questions?.Length ?? 0;
        protected int QuestionIndex { get; set; }

        #endregion

        #region Answers

        protected bool[] Answers { get; set; }
        public int YesCount => Answers?.Count(a => a) ?? 0;

        #endregion

        #endregion

        #region Public methods

        #region Constructor

        public SeadmState(string stateId, SeadmStateTypeEnum stateType = SeadmStateTypeEnum.Regular)
        {
            StateId   = stateId;
            StateType = stateType;
        }

        #endregion

        #region Populate questions

        public void PopulateQuestions(SeadmQuestion[] questions)
        {
            // Non-terminal states require at least one question for transition
            if (questions.Length == 0 && StateType != SeadmStateTypeEnum.Terminal)
            {
                throw new Exception(
                    $"PopulateQuestions(): No questions defined for state {StateId}.");
            }
            else
            {
                Questions = questions;
                Answers = new bool[QuestionCount];
            }
        }

        #endregion

        #region Get current question

        public string GetCurrentQuestion() =>
            Questions[QuestionIndex].Text;

        #endregion

        #region Next / Previous Question

        public bool NextQuestion(bool value)
        {
            Answers[QuestionIndex] = value;

            bool hasNextQuestion = 
                HasNextQuestion();

            if (hasNextQuestion)
            {
                QuestionIndex++;
            }

            return !hasNextQuestion;
            
        }

        public bool PreviousQuestion()
        {
            bool hasPreviousQuestion = 
                HasPreviousQuestion();

            if (hasPreviousQuestion)
            {
                QuestionIndex--;
            }

            return !hasPreviousQuestion;
        }

        #endregion

        #region Has Next/Previous Question

        public bool HasNextQuestion() =>
            QuestionCount > 0 && 
            QuestionCount != QuestionIndex + 1;

        public bool HasPreviousQuestion() =>
            QuestionIndex > 0;

        #endregion

        #region Reset

        public void Reset()
        {
            QuestionIndex = 0;
            PreviousStateId = string.Empty;

            for (int i = 0; i < Answers.Length; 
                Answers[i++] = false);
        }

        #endregion

        #endregion
    }
}
