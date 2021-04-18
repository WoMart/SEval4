using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4.Models
{
    public abstract class BaseTextValuePair
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public int Value { get; set; }
    }
}
