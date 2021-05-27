using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4.Models
{
    public class AttemptCount
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Participant))]
        public Guid UserId { get; set; }
        public int ScenarioId { get; set; }
        public int Attempts { get; set; }

        public virtual Participant Participant { get; set; }
    }
}
