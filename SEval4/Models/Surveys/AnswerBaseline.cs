using System;
using System.ComponentModel.DataAnnotations;

namespace SEval4.Models
{
    public class AnswerBaseline
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public Guid UserGuid { get; set; }
        [Required]
        public int ScenarioId { get; set; }
        [Required, Range(1, 4)]
        public int Value { get; set; }
    }
}
