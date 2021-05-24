using System.ComponentModel.DataAnnotations.Schema;

namespace SEval4.Models
{
    public class EvalScenario : BaseScenario
    {
        public string Feedback { get; set; }
        [NotMapped]
        public bool IsAnsweredCorrectly { get; set; } = false;

    }
}
