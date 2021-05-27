using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEval4.Models
{
    public class EvalAnswer
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Participant))]
        public Guid UserId { get; set; }
        public DateTime InsertTime { get; set; }
        public int ScenarioId { get; set; }
        public int ResponseValue { get; set; }
        public bool IsCorrect { get; set; }

        public virtual Participant Participant { get; set; }
    }
}
