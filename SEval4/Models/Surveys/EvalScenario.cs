using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4.Models
{
    public class EvalScenario : Scenario
    {
        public string Feedback { get; set; }
        [NotMapped]
        public bool IsAnsweredCorrectly { get; set; } = false;

    }
}
