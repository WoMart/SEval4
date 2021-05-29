using System.ComponentModel.DataAnnotations;

namespace SEval4.Models
{
    public class EvalResponse : BaseResponse<EvalResponse>
    {
        [Required]
        public bool IsCorrect { get; set; }
    }
}
