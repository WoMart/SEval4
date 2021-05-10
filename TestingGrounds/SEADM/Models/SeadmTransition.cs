using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGrounds.SEADM.Models
{
    class SeadmTransition
    {
        public string StateId { get; set; }
        public int YesCount { get; set; }
        public string NextStateId { get; set; }
    }
}
