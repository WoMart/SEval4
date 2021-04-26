using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4.Models
{
    public class ScenarioResponse : BaseTextValuePair<int>
    {
        public string Tag { get; set; }

        public bool Correct { get; set; }

        public Guid ScenarioId { get; set; }

        public virtual Scenario Scenario { get; set; }
    }

    public class ResponseTest : BaseTextValuePair<int>
    {
        public string Tag { get; set; }

        public bool Correct { get; set; }

        public Guid ScenarioId { get; set; }

        public ResponseTest(ScenarioResponse response)
        {
            Id = response.Id;
            Text = response.Text;
            Value = response.Value;
            Tag = response.Tag;
            Correct = response.Correct;
            ScenarioId = response.ScenarioId;
        }
    }
}
