using SEval4.Models.SeadmModels;
using System;
using System.Linq;

namespace SEval4.Data.Services
{
    public class SeadmService
    {
        #region Member Variables

        #region Data

        protected SeadmState[] States;
        protected SeadmTransition[] Transitions;
        protected SeadmQuestion[] StateQuestions;

        #endregion

        #region Current state

        public SeadmState CurrentState;

        #endregion

        #endregion

        #region Public methods

        #region Constructor

        public SeadmService()
        {
            // Populate data
            States = SeedSeadm.SeadmStatesSeed;
            Transitions = SeedSeadm.SeadmTransitionsSeed;
            StateQuestions = SeedSeadm.SeadmQuestionsSeed;

            // Populate States with Questions and set Starting State
            PopulateStateQuestions();
            SetStartingState();
        }

        #endregion

        #region Get current questions

        public string GetCurrentQuestion() =>
            CurrentState.GetCurrentQuestion();

        #endregion

        #region Question navigation

        public void NextQuestion(bool value)
        {
            bool goToNextState = 
                CurrentState.NextQuestion(value);
            
            // If that was the last question in the state, transition
            if (goToNextState)
            {
                NextState();
            }
        }

        public void PreviousQuestion()
        {
            bool goToPreviousState =
                CurrentState.PreviousQuestion();

            // If that was the first question, return to previous state
            if (goToPreviousState)
            {
                PreviousState();
            }
        }

        #endregion

        #region Resest states

        /// <summary>
        /// Reset each state and set CurrentState to the starting state
        /// </summary>
        public void Reset()
        {
            // Reset each state
            for (int i = 0; i < States.Length; 
                States[i++].Reset());

            // Set CurrentState to the starting one
            SetStartingState();
        }

        #endregion

        #endregion

        #region Protected methods

        protected void SetStartingState()
        {
            SeadmState startingState = States
                .FirstOrDefault(s => s.StateType == SeadmStateTypeEnum.Starting);

            if (startingState is null)
            {
                throw new ArgumentNullException(
                    "SEADM could not find the starting state. " +
                    "Have you defined a starting state?");
            }
            else
            {
                CurrentState = startingState;
            }
        }

        protected void PopulateStateQuestions()
        {
            // Populate each state with assigned questions
            foreach (SeadmState state in States)
            {
                state.PopulateQuestions(StateQuestions
                    .Where(q => q.StateId == state.StateId)
                    .ToArray());
            }
        }

        #region State navigation

        protected void NextState()
        {
            // Don't transition if state is terminal
            if (CurrentState.StateType == SeadmStateTypeEnum.Terminal)
            {
                return;
            }

            // Find transition 
            SeadmTransition transition = Transitions
                .FirstOrDefault(t =>
                t.StateId == CurrentState.StateId &&
                t.YesCount == CurrentState.YesCount);

            // If no transition result found or its ID is empty, throw
            if (string.IsNullOrEmpty(transition?.NextStateId))
            {
                throw new ArgumentNullException(
                    $"NextState(): No transition found for " +
                    $"(State: {CurrentState.StateId}, YesCount: {CurrentState.YesCount}).");
            }
            else
            {
                // Transition and record the previous state
                SetState(transition.NextStateId, CurrentState.StateId);
            }
        }

        protected void PreviousState()
        {
            // Don't transition if state is starting
            if (CurrentState.StateType == SeadmStateTypeEnum.Starting)
            {
                return;
            }

            // If previous state is not recorded, exception
            if (string.IsNullOrEmpty(CurrentState.PreviousStateId))
            {
                throw new ArgumentNullException(
                    $"NextState(): State {CurrentState.StateId} lacks memory of the previous state.");
            }
            else
            {
                SetState(CurrentState.PreviousStateId);
            }
        }

        protected void SetState(string stateId, string previousStateId = null)
        {
            SeadmState state = States
                .FirstOrDefault(s => s.StateId == stateId);

            if (state is null)
            {
                throw new ArgumentNullException(
                    $"SetState(): Cannot transition to state {stateId} from {CurrentState.StateId}");
            }
            else
            {
                if (!string.IsNullOrEmpty(previousStateId))
                {
                    state.PreviousStateId = previousStateId;
                }

                CurrentState = state;
            }
        }

        #endregion

        #endregion

    }
}
