using System;
using System.ComponentModel.DataAnnotations;

namespace SEval4.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Guid UserId { get; set; }

    }
}
