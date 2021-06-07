using System;
using System.ComponentModel.DataAnnotations;

namespace SEval4.Models
{
    public class ParticipantFeedback
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }

        // Feedback form
        [Required]
        public string StudyHelpfulness { get; set; }
        [Required]
        public string PhishingConfidenceChange { get; set; }
        [Required]
        public string SpearPhishingConfidenceChange { get; set; }
        
        // Text answers, optional
        public string ScenarioFeedback { get; set; }
        public string TrainingFeedback { get; set; }
        public string GeneralFeedback { get; set; }
    }
}
