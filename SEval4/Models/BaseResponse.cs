using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        
        [ForeignKey(nameof(ScenarioId))]
        public virtual Scenario Scenario { get; set; }
    }
}
