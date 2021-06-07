using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEval4.Models
{
    public abstract class BaseAnswer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime CreateTime { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public int ScenarioId { get; set; }

        [Required]
        public int ResponseId { get; set; }

        [Required]
        public bool IsCorrect { get; set; }

        //[ForeignKey(nameof(UserId))]
        //public virtual Participant Participant { get; set; }

        //[ForeignKey(nameof(ScenarioId))]
        //public virtual Scenario Scenario { get; set; }

    }
}
