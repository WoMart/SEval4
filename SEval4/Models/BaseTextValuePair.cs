using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4.Models
{
    public abstract class BaseTextValuePair<T>
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public T Value { get; set; }
    }
}
