using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4.Models
{
    public class ScenarioOption :  BaseTextValuePair<int>
    {
        public int ScenarioId { get; set; }

        public virtual SurveyScenario SurveyScenario { get; set; }
    }
}
