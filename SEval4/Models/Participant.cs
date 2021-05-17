using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4.Models
{
    public class Participant
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public bool IsFinished { get; set; }
        [Required]
        public DateTime CreationTime { get; set; }
        public DateTime? AllocationTime { get; set; }
        [ForeignKey(nameof(StudyGroup))]
        public int? StudyGroupId { get; set; }
        public virtual StudyGroup StudyGroup { get; set; }
    }
}
