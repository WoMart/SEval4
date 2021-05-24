using System;
using System.ComponentModel.DataAnnotations;

namespace SEval4.Models
{
    public class Scenario
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public int ScenarioId { get; set; }
        [Required]
        public string Context { get; set; }
    }
}
