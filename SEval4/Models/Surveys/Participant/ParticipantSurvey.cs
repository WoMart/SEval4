using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEval4.Models
{
    public class ParticipantSurvey
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public string AgeGroup { get; set; }

        [Required]
        public string EducationGroup { get; set; }

        [Required]
        public string ProfessionalExperience { get; set; }

        [Required]
        public string HasFormalTraining { get; set; }

        [Required]
        public string HasInformalTraining { get; set; }

        [Required]
        public string PhishingConfidence { get; set; }

        [Required]
        public string SpearPhishingConfidence { get; set; }
    }

}
