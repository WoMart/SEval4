using System;
using System.ComponentModel.DataAnnotations;

namespace SEval4.Models
{
    public abstract class BaseTextValuePair
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string Text { get; set; }
        [Required]
        public int Value { get; set; }
    }
}
