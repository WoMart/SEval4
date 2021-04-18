/*
 * Questions:
 * 1. Age
 * 2. Experience with games (?)
 * 3. Worked in communicative job
 * 4. Training in social engineering detection
 * 5. Confidence in own skills
 * 
 */
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
        public int AgeGroup { get; set; }

        [Required]
        public int EducationGroup { get; set; }

        [Required]
        public int ProfessionalExperience { get; set; }

        [Required]
        public int HasFormalTraining { get; set; }

        [Required]
        public int HasInformalTraining { get; set; }

        [Required]
        public int PhishingConfidence { get; set; }

        [Required]
        public int HumanConfidence { get; set; }
    }
}
