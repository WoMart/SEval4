using System;
using System.ComponentModel.DataAnnotations;

namespace SEval4.Models
{
    public class StudyGroup
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Guid Identifier { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
