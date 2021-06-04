using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEval4.Models
{
    public class SurveyAnswer : BaseAnswer
    {
        [Required]
        public string SurveyName { get; set; }

        //[ForeignKey(nameof(ResponseValue))]
        //public virtual Response Response { get; set; }
    }
}
