﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEval4.Models
{
    public class ParticipantSurvey
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required, Range(1, 6)]
        public int AgeGroup { get; set; }

        [Required, Range(1, 6)]
        public int EducationGroup { get; set; }

        [Required, Range(1, 4)]
        public int ProfessionalExperience { get; set; }

        [Required, Range(1, 2)]
        public int HasFormalTraining { get; set; }

        [Required, Range(1, 2)]
        public int HasInformalTraining { get; set; }

        [Required, Range(1, 5)]
        public int PhishingConfidence { get; set; }

        [Required, Range(1, 5)]
        public int HumanConfidence { get; set; }
    }
}
