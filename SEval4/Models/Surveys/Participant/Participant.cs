using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4.Models
{
    public class Participant
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime CreationTime { get; set; }
        [Required]
        public bool IsFinished { get; set; }

        #region Study group

        public int? StudyGroupId { get; set; }
        public DateTime? AllocationTime { get; set; }

        #endregion

        #region Progression 

        public DateTime? ParticipantSurveyCompletionTime { get; set; }
        public DateTime? BaselineSurveyCompletionTime { get; set; }
        public DateTime? EvaluationCompletionTime { get; set; }
        public DateTime? PostgameSurveyCompletionTime { get; set; }
        public DateTime? FeedbackCompletionTime { get; set; }

        #endregion


        [ForeignKey(nameof(StudyGroupId))]
        public virtual StudyGroup StudyGroup { get; set; }
    }
}
