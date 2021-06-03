using System;
using System.ComponentModel.DataAnnotations;

namespace SEval4.Models
{
    public class StudyGroup
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string Name { get; set; }
        [Required]
        public Guid Identifier { get; set; } = Guid.NewGuid();
    }
}
