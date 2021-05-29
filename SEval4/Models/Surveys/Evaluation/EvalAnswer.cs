using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEval4.Models
{
    public class EvalAnswer : BaseAnswer
    {
        [Required]
        public bool IsCorrect { get; set; }

        //[ForeignKey(nameof(ResponseValue))]
        //public virtual EvalResponse Response {get;set;}
    }
}
