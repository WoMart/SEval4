using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4.Models
{
    public class BaseTextValuePair
    {
        public int Id => Convert.ToInt32(Value);

        public string Text { get; set; }

        public string Value { get; set; }
    }
}
