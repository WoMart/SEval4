using System.ComponentModel.DataAnnotations;

namespace SEval4.Models
{
    public class Response : BaseTextValuePair<int>
    {
        [Required]
        public int ScenarioId { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int ResponseOrder { get; set; }

        public bool? IsCorrect { get; set; }

    }
}
