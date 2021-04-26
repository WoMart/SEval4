using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SEval4.Models
{
    public class Scenario
    {
        [Key]
        public Guid ScenarioId { get; set; }

        public string Context { get; set; }

        public Guid Correct { get; set; }

        public virtual ICollection<ScenarioResponse> Responses { get; set; }
    }

    public class ScenarioTest
    {
        public Guid ScenarioId { get; set; }

        public string Context { get; set; }

        public Guid Correct { get; set; }

        public List<ScenarioResponse> Responses { get; set; }

        public ScenarioTest(Scenario scenario)
        {
            ScenarioId = scenario.ScenarioId;
            Context = scenario.Context;
            Correct = scenario.Correct;

        }
    }
}
