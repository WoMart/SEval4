using System;

namespace SEval4.Models
{
    public abstract class BaseTextValuePair<T>
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Text { get; set; }

        public T Value { get; set; }
    }
}
