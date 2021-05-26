using System;
using System.ComponentModel.DataAnnotations;

namespace SEval4.Models
{
    public class StudyGroup
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
    }
}
