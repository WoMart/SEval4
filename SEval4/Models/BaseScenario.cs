using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4.Models
{
    public abstract class BaseScenario
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public int ScenarioId { get; set; }
        [Required]
        public string Context { get; set; }
    }
}
