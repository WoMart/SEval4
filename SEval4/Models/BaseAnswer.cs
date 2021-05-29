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
        public DateTime InsertTime { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public int ScenarioId { get; set; }

        [Required]
        public int ResponseValue { get; set; }

        // TODO: EntityFramework is complaining about cascading ForeignKey
        //       Might have to make the Id properties nullable to solve the issue

        //[ForeignKey(nameof(UserId))]
        //public virtual Participant Participant { get; set; }

        //[ForeignKey(nameof(ScenarioId))]
        //public virtual Scenario Scenario { get; set; }

    }
}
