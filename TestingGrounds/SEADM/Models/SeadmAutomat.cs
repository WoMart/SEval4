using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGrounds.SEADM.Models
{
    class SeadmAutomat
    {
        public List<SeadmState> States { get; private set; }
        public SeadmState Current { get; set; }

        public SeadmAutomat()
        {
            States  = _States;
            Current = States?
                .SingleOrDefault(s =>
                s.StateType == StateTypeEnum.Starting);

            if (Current is null)
            {
                throw new ArgumentNullException(
                    $"SeadmAutomat constructor could not find the start state.");
            }
        }

        #region Public methods

        public string GetQuestion() =>
            Current.GetCurrentQuestion();

        public void NextQuestion(bool value)
        {
            if (Current.NextQuestion(value))
            {
                NextState();
            }
        }

        public void PreviousQuestion()
        {
            if (Current.PreviousQuestion())
            {
                PreviousState();
            }
        }

        public void Reset()
        {
            for (int i = 0; i < States.Count; i++)
            {
                States[i].Reset();

                if (States[i].StateType == StateTypeEnum.Starting)
                {
                    Current = States[i];
                }
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("STATES\n");
            for (int i = 0;
                i < States.Count;
                States[i++].PrintInfo()) ;

            Console.WriteLine("\n\nTRANSITIONS\n");
            for (int i = 0; i < Transitions.Count; i++)
            {
                SeadmTransition transition = Transitions[i];
                Console.WriteLine(
                    $"Q{i + 1}: ({transition.StateId}, {transition.YesCount}) => {transition.NextStateId}");
            };
        }

        #endregion

        #region Protected methods

        protected void NextState()
        {
            if (Current.StateType == StateTypeEnum.Terminal)
            {
                return;
            }

            SeadmTransition transition = Transitions
                .SingleOrDefault(t =>
                t.StateId == Current.StateId &&
                t.YesCount == Current.YesCount);

            // If no transition result found or its ID is empty, throw
            if (string.IsNullOrEmpty(transition?.NextStateId))
            {
                throw new ArgumentNullException(
                    $"NextState(): No transition found for (State: {Current.StateId}, YesCount: {Current.YesCount}).");
            }

            SetState(transition.NextStateId, Current.StateId);
        }

        protected void PreviousState()
        {
            if (Current.StateType == StateTypeEnum.Starting)
            {
                return;
            }

            if (string.IsNullOrEmpty(Current.PreviousStateId))
            {
                throw new ArgumentNullException(
                    $"NextState(): State {Current.StateId} lacks memory of the previous state.");
            }

            SetState(Current.PreviousStateId);
        }

        protected void SetState(string stateId, string previousStateId = null)
        {
            SeadmState state = States
                .SingleOrDefault(s =>
                s.StateId == stateId);

            if (state is null)
            {
                throw new ArgumentNullException(
                    $"SetState(): Cannot transition to state {Current.PreviousStateId} from {Current.StateId}");
            }
            else
            {
                if (!string.IsNullOrEmpty(previousStateId))
                {
                    state.PreviousStateId = previousStateId;
                }

                Current = state;
            }
        }

        #endregion

        public static readonly List<SeadmTransition> Transitions = new()
        {
            // Transition States
            new SeadmTransition
            {
                StateId = "S1",
                YesCount = 1,
                NextStateId = "S3",
            },
            new SeadmTransition
            {
                StateId = "S1",
                YesCount = 0,
                NextStateId = "S2",
            },
            new SeadmTransition
            {
                StateId = "S2",
                YesCount = 1,
                NextStateId = "SE",
            },
            new SeadmTransition
            {
                StateId = "S2",
                YesCount = 0,
                NextStateId = "SR",
            },
            new SeadmTransition
            {
                StateId = "S3",
                YesCount = 1,
                NextStateId = "S4",
            },
            new SeadmTransition
            {
                StateId = "S3",
                YesCount = 0,
                NextStateId = "SR",
            },
            new SeadmTransition
            {
                StateId = "S4",
                YesCount = 1,
                NextStateId = "S5",
            },
            new SeadmTransition
            {
                StateId = "S4",
                YesCount = 0,
                NextStateId = "SR",
            },
            new SeadmTransition
            {
                StateId = "S5",
                YesCount = 1,
                NextStateId = "S6",
            },
            new SeadmTransition
            {
                StateId = "S5",
                YesCount = 0,
                NextStateId = "SR",
            },
            new SeadmTransition
            {
                StateId = "S6",
                YesCount = 1,
                NextStateId = "SA",
            },
            new SeadmTransition
            {
                StateId = "S6",
                YesCount = 0,
                NextStateId = "S7",
            },
            new SeadmTransition
            {
                StateId = "S7",
                YesCount = 1,
                NextStateId = "SA",
            },
            new SeadmTransition
            {
                StateId = "S7",
                YesCount = 0,
                NextStateId = "S8",
            },
            new SeadmTransition
            {
                StateId = "S8",
                YesCount = 1,
                NextStateId = "S12",
            },
            new SeadmTransition
            {
                StateId = "S8",
                YesCount = 0,
                NextStateId = "S9",
            },
            new SeadmTransition
            {
                StateId = "S9",
                YesCount = 1,
                NextStateId = "S12",
            },
            new SeadmTransition
            {
                StateId = "S9",
                YesCount = 0,
                NextStateId = "S10",
            },
            new SeadmTransition
            {
                StateId = "S10",
                YesCount = 1,
                NextStateId = "S12",
            },
            new SeadmTransition
            {
                StateId = "S10",
                YesCount = 0,
                NextStateId = "S11",
            },
            new SeadmTransition
            {
                StateId = "S11",
                YesCount = 1,
                NextStateId = "S12",
            },
            new SeadmTransition
            {
                StateId = "S11",
                YesCount = 0,
                NextStateId = "SA",
            },
            new SeadmTransition
            {
                StateId = "S12",
                YesCount = 1,
                NextStateId = "S13",
            },
            new SeadmTransition
            {
                StateId = "S12",
                YesCount = 0,
                NextStateId = "SR",
            },
            new SeadmTransition
            {
                StateId = "S13",
                YesCount = 0,
                NextStateId = "SR",
            },
            new SeadmTransition
            {
                StateId = "S13",
                YesCount = 1,
                NextStateId = "S14",
            },
            new SeadmTransition
            {
                StateId = "S13",
                YesCount = 2,
                NextStateId = "S14",
            },
            new SeadmTransition
            {
                StateId = "S13",
                YesCount = 3,
                NextStateId = "S16",
            },
            new SeadmTransition
            {
                StateId = "S13",
                YesCount = 4,
                NextStateId = "S16",
            },
            new SeadmTransition
            {
                StateId = "S14",
                YesCount = 1,
                NextStateId = "S15",
            },
            new SeadmTransition
            {
                StateId = "S14",
                YesCount = 0,
                NextStateId = "SR",
            },
            new SeadmTransition
            {
                StateId = "S15",
                YesCount = 1,
                NextStateId = "S16",
            },
            new SeadmTransition
            {
                StateId = "S15",
                YesCount = 0,
                NextStateId = "SR",
            },
            new SeadmTransition
            {
                StateId = "S16",
                YesCount = 1,
                NextStateId = "SA",
            },
            new SeadmTransition
            {
                StateId = "S16",
                YesCount = 0,
                NextStateId = "SR",
            },
        };
        private static readonly List<SeadmState> _States = new()
        {
            new SeadmState("SA", StateTypeEnum.Terminal),
            new SeadmState("SR", StateTypeEnum.Terminal),
            new SeadmState("SE", StateTypeEnum.Terminal),
            new SeadmState("S1", StateTypeEnum.Starting),
            new SeadmState("S2"),
            new SeadmState("S3"),
            new SeadmState("S4"),
            new SeadmState("S5"),
            new SeadmState("S6"),
            new SeadmState("S7"),
            new SeadmState("S8"),
            new SeadmState("S9"),
            new SeadmState("S10"),
            new SeadmState("S11"),
            new SeadmState("S12"),
            new SeadmState("S13"),
            new SeadmState("S14"),
            new SeadmState("S15"),
            new SeadmState("S16"),
        };
    }
}
