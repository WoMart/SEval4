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
}
