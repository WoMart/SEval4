using System.ComponentModel.DataAnnotations;

namespace SEval4.Models
{
    public class StudyGroup
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
