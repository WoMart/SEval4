using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4.Models
{
    public class ParticipantBaseline
    {
        [Key]
        public Guid Id { get; set; }

        public Guid UserGuid { get; set; }


    }
}
