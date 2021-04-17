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
using SEval4.Models.Enums;

namespace SEval4.Models
{
    public class ParticipantSurvey
    {
        [Required]
        public string AgeGroup { get; set; }

        [Required]
        public string JobExperience { get; set; }
        
        [Required]
        public string TrainingExperience { get; set; }

        [Required]
        public string GameExperience { get; set; }

        [Required]
        public string SelfConfidence { get; set; }
    }
}
