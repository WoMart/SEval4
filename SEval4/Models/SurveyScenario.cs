using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4.Models
{
    public class SurveyScenario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ScenarioText { get; set; }

        public virtual ICollection<ScenarioOption> SurveyOptions { get; set; }
    }
}
