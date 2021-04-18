using SEval4.Models;
using System.Collections.Generic;

namespace SEval4.Data
{
    public static class SeedSurvey
    {
        public static readonly List<AgeGroup> AgeGroupsSeed = new()
        {
            new AgeGroup
            {
                Id = 1,
                Text = "18 - 24 years old",
                Value = 1,
            },
            new AgeGroup
            {
                Id = 2,
                Text = "25 - 34 years old",
                Value = 2,
            },
            new AgeGroup
            {
                Id = 3,
                Text = "35 - 44 years old",
                Value = 3,
            },
            new AgeGroup
            {
                Id = 4,
                Text = "45 - 54 years old",
                Value = 4,
            },
            new AgeGroup
            {
                Id = 5,
                Text = "55 - 64 years old",
                Value = 5,
            },
            new AgeGroup
            {
                Id = 6,
                Text = "65+ years old",
                Value = 6,
            },
        };

        public static readonly List<YearGroup> YearGroupsSeed = new()
        {
            new YearGroup
            {
                Id = 1,
                Text = "1 year or less",
                Value = 1,
            },
            new YearGroup
            {
                Id = 2,
                Text = "2 - 3 years",
                Value = 2,
            },
            new YearGroup
            {
                Id = 3,
                Text = "4 - 5 years",
                Value = 3,
            },
            new YearGroup
            {
                Id = 4,
                Text = "6 years or more",
                Value = 4,
            },
        };

        public static readonly List<EducationGroup> EducationGroupsSeed = new()
        {
            new EducationGroup
            {
                Id = 1,
                Text = "Primary Education",
                Value = 1,
            },
            new EducationGroup
            {
                Id = 2,
                Text = "Secondary Education",
                Value = 2,
            },
            new EducationGroup
            {
                Id = 3,
                Text = "Vocational training",
                Value = 3,
            },
            new EducationGroup
            {
                Id = 4,
                Text = "Bachelor degree or equivalent",
                Value = 4,
            },
            new EducationGroup
            {
                Id = 5,
                Text = "Postgraduate Master",
                Value = 5,
            },
            new EducationGroup
            {
                Id = 6,
                Text = "PhD",
                Value = 6,
            },
        };

        public static readonly List<ConfidenceGroup> ConfidenceGroupsSeed = new()
        {
            new ConfidenceGroup
            {
                Id = 1,
                Text = "No confidence",
                Value = 1,
            },
            new ConfidenceGroup
            {
                Id = 2,
                Text = "Low confidence",
                Value = 2,
            },
            new ConfidenceGroup
            {
                Id = 3,
                Text = "Moderate confidence",
                Value = 3,
            },
            new ConfidenceGroup
            {
                Id = 4,
                Text = "High confidence",
                Value = 4,
            },
            new ConfidenceGroup
            {
                Id = 5,
                Text = "Full confidence",
                Value = 5,
            },

        };
    }
}
