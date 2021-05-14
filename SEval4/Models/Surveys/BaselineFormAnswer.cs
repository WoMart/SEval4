using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4.Models
{
    public class BaselineFormAnswer
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public Guid UserGuid { get; set; }
        [Required]
        public int ScenarioId { get; set; }
        [Required]
        public string Value { get; set; }
    }
}
