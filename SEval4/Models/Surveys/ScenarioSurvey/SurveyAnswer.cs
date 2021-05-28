using System;
using System.ComponentModel.DataAnnotations;

namespace SEval4.Models
{
    public class SurveyAnswer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Guid UserGuid { get; set; }
        [Required]
        public int ScenarioId { get; set; }
        [Required, Range(1, 4)]
        public int Value { get; set; }
    }
}
