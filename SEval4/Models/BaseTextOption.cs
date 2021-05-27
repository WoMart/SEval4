using System.ComponentModel.DataAnnotations;

namespace SEval4.Models
{
    public abstract class BaseTextOption
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
    }
}
