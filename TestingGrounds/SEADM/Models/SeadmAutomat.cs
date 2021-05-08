using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGrounds.SEADM.Models
{
    class SeadmAutomat
    {
        public List<State> States { get; private set; }
        public State Current { get; set; }

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

        #region State navigation

        public void NextState()
        {
            if (Current.StateType == StateTypeEnum.Terminal)
            {
                return;
            }

            Transition nextState = Transitions
                .SingleOrDefault(t =>
                t.StateID == Current.StateId &&
                t.YesCount == Current.YesCount);

            // If no transition result found or its ID is empty, throw
            if (string.IsNullOrEmpty(nextState?.NextStateId))
            {
                throw new ArgumentNullException(
                    $"NextState(): No transition found for (State: {Current.StateId}, YesCount: {Current.YesCount}).");
            }

            SetState(nextState?.StateID ?? string.Empty);
        }

        public void PreviousState()
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

        protected void SetState(string stateId)
        {
            State state = States
                .SingleOrDefault(s =>
                s.StateId == stateId);

            if (state is null)
            {
                throw new ArgumentNullException(
                    $"SetState(): Cannot transition to state {Current.PreviousStateId} from {Current.StateId}");
            }
            else
            {
                Current = state;
            }
        }

        #endregion

        public static readonly List<Transition> Transitions = new()
        {
            // Terminal States
            new Transition
            {
                StateID = "SA",
                YesCount = 1,
                NextStateId = string.Empty,
            },
            new Transition
            {
                StateID = "SF",
                YesCount = 0,
                NextStateId = string.Empty,
            },
            new Transition
            {
                StateID = "SE",
                YesCount = 1,
                NextStateId = string.Empty,
            },
            // Transition States
            new Transition
            {
                StateID = "S1",
                YesCount = 1,
                NextStateId = "S3",
            },
            new Transition
            {
                StateID = "S1",
                YesCount = 0,
                NextStateId = "S2",
            },
            new Transition
            {
                StateID = "S2",
                YesCount = 1,
                NextStateId = "SE",
            },
            new Transition
            {
                StateID = "S2",
                YesCount = 0,
                NextStateId = "SR",
            },
            new Transition
            {
                StateID = "S3",
                YesCount = 1,
                NextStateId = "S4",
            },
            new Transition
            {
                StateID = "S3",
                YesCount = 0,
                NextStateId = "SR",
            },
            new Transition
            {
                StateID = "S4",
                YesCount = 1,
                NextStateId = "S5",
            },
            new Transition
            {
                StateID = "S4",
                YesCount = 0,
                NextStateId = "SR",
            },
            new Transition
            {
                StateID = "S5",
                YesCount = 1,
                NextStateId = "S6",
            },
            new Transition
            {
                StateID = "S5",
                YesCount = 0,
                NextStateId = "SR",
            },
            new Transition
            {
                StateID = "S6",
                YesCount = 1,
                NextStateId = "SA",
            },
            new Transition
            {
                StateID = "S6",
                YesCount = 0,
                NextStateId = "S7",
            },
            new Transition
            {
                StateID = "S7",
                YesCount = 1,
                NextStateId = "SA",
            },
            new Transition
            {
                StateID = "S7",
                YesCount = 0,
                NextStateId = "S8",
            },
            new Transition
            {
                StateID = "S8",
                YesCount = 1,
                NextStateId = "S12",
            },
            new Transition
            {
                StateID = "S8",
                YesCount = 0,
                NextStateId = "S9",
            },
            new Transition
            {
                StateID = "S9",
                YesCount = 1,
                NextStateId = "S12",
            },
            new Transition
            {
                StateID = "S9",
                YesCount = 0,
                NextStateId = "S10",
            },
            new Transition
            {
                StateID = "S10",
                YesCount = 1,
                NextStateId = "S12",
            },
            new Transition
            {
                StateID = "S10",
                YesCount = 0,
                NextStateId = "S11",
            },
            new Transition
            {
                StateID = "S11",
                YesCount = 1,
                NextStateId = "S12",
            },
            new Transition
            {
                StateID = "S11",
                YesCount = 0,
                NextStateId = "SA",
            },
            new Transition
            {
                StateID = "S12",
                YesCount = 1,
                NextStateId = "S13",
            },
            new Transition
            {
                StateID = "S12",
                YesCount = 0,
                NextStateId = "SF",
            },
            new Transition
            {
                StateID = "S13",
                YesCount = 0,
                NextStateId = "SF",
            },
            new Transition
            {
                StateID = "S13",
                YesCount = 1,
                NextStateId = "S14",
            },
            new Transition
            {
                StateID = "S13",
                YesCount = 2,
                NextStateId = "S14",
            },
            new Transition
            {
                StateID = "S13",
                YesCount = 3,
                NextStateId = "S16",
            },
            new Transition
            {
                StateID = "S13",
                YesCount = 4,
                NextStateId = "S16",
            },
            new Transition
            {
                StateID = "S14",
                YesCount = 1,
                NextStateId = "S15",
            },
            new Transition
            {
                StateID = "S14",
                YesCount = 0,
                NextStateId = "SF",
            },
            new Transition
            {
                StateID = "S15",
                YesCount = 1,
                NextStateId = "S16",
            },
            new Transition
            {
                StateID = "S15",
                YesCount = 0,
                NextStateId = "SF",
            },
            new Transition
            {
                StateID = "S16",
                YesCount = 1,
                NextStateId = "SA",
            },
            new Transition
            {
                StateID = "S16",
                YesCount = 0,
                NextStateId = "SF",
            },
        };
        private static readonly List<State> _States = new()
        {
            new State("SA", StateTypeEnum.Terminal),
            new State("SR", StateTypeEnum.Terminal),
            new State("SE", StateTypeEnum.Terminal),
            new State("S1", StateTypeEnum.Starting),
            new State("S2"),
            new State("S3"),
            new State("S4"),
            new State("S5"),
            new State("S6"),
            new State("S7"),
            new State("S8"),
            new State("S9"),
            new State("S10"),
            new State("S11"),
            new State("S12"),
            new State("S13"),
            new State("S14"),
            new State("S15"),
            new State("S16"),
        };
    }
}
