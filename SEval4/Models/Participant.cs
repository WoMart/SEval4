using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4.Models
{
    public class Participant
    {
        public Guid Id { get; set; }
        [Required]
        public DateTime CreationTime { get; set; }
        public int AllocatedGroup { get; set; }
        public DateTime AllocationTime { get; set; }
        [Required]
        public bool IsFinished { get; set; }
    }
}
