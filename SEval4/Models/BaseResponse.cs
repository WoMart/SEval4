using System.ComponentModel.DataAnnotations;

namespace SEval4.Models
{
    public class BaseResponse : BaseTextOption
    {
        [Required]
        public int ScenarioId { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Value { get; set; }
    }
}
