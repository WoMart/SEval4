using System;

namespace SEval4.Models
{
    public abstract class BaseTextValuePair
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Text { get; set; }

        public int Value { get; set; }
    }
}
