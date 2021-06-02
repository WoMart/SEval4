using System;
using System.ComponentModel.DataAnnotations;

namespace SEval4.Models
{
    public class ScenariosSeenByParticipant
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public string InSurvey { get; set; }

        [Required]
        public int ScenarioId { get; set; }
    }
}
