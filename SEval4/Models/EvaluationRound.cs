using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4.Models
{
    public class EvaluationRound
    {
        public int ScenarioId { get; set; }
        public int AttemptCount { get; set; }
        public bool IsAnsweredCorrectly { get; set; }
    }
}
