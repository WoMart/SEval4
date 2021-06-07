using SEval4.Models.SeadmModels;

namespace SEval4.Data
{
    public static class SeedSeadm
    {
        #region States

        public static readonly SeadmState[] SeadmStatesSeed =
        {
            // Terminal states
            new SeadmState("SA", SeadmStateTypeEnum.Terminal),
            new SeadmState("SR", SeadmStateTypeEnum.Terminal),
            new SeadmState("SE", SeadmStateTypeEnum.Terminal),
            // Transitionable states
            new SeadmState("S1", SeadmStateTypeEnum.Starting),
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
            //new SeadmState("S15"),
            new SeadmState("S16"),

        };

        #endregion

        #region Questions

        public static readonly SeadmQuestion[] SeadmQuestionsSeed =
            {
            new SeadmQuestion
            {
                StateId = "SA",
                Text = "It is safe to fulfil the request.",
            },
            new SeadmQuestion
            {
                StateId = "SR",
                Text = "Refuse to fulfil the request or defer it to a suitable party.",
            },
            new SeadmQuestion
            {
                StateId = "SE",
                Text = "Ask the requester for elaboration or clarification and evaluate the request based on their answers.",
            },
            new SeadmQuestion
            {
                StateId = "SV",
                Text = "Verify the requester through a third party and decide based on the verification result.",
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
            //new SeadmQuestion
            //{
            //    StateId = "S15",
            //    Text = "Does the verification process reflect the same information as verification requirements?",
            //},
            new SeadmQuestion
            {
                StateId = "S16",
                Text = "Does the requester have the necessary authority to request the action or the information?",
            },
        };

        #endregion

        #region Transitions

        public static readonly SeadmTransition[] SeadmTransitionsSeed =
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
                NextStateId = "SV",
                //NextStateId = "S15",
            },
            new SeadmTransition
            {
                StateId = "S14",
                YesCount = 0,
                NextStateId = "SR",
            },
            //new SeadmTransition
            //{
            //    StateId = "S15",
            //    YesCount = 1,
            //    NextStateId = "S16",
            //},
            //new SeadmTransition
            //{
            //    StateId = "S15",
            //    YesCount = 0,
            //    NextStateId = "SR",
            //},
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

        #endregion
    }
}
