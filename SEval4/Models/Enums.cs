using System;
using System.ComponentModel;
using System.Reflection;

namespace SEval4.Models.Enums
{
    public static class Extensions
    {
        public static string ToString(this Enum value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);

            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    DescriptionAttribute attr =
                        Attribute.GetCustomAttribute(field,
                        typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attr != null)
                    {
                        return attr.Description;
                    }
                }
            }

            return null;
        }

    }

    public enum AgeGroupEnum
    {
        [Description("Please select...")]
        None,
        AG_18to24,
        AG_25to34,
        AG_35to44,
        AG_45to54,
        AG_55to64,
        AG_65plus,
    }

    public enum GameExperienceEnum 
    { 
        None,
        NoExperience,
        LowExperience,
        MidExperience,
        HighExperience,
        Expert,
    }

    public enum JobExperienceEnum
    {
        None,
        NoExperience,
        LowExperience,
        MidExperience,
        HighExperience,
        Expert,
    }

    public enum TrainingExperienceEnum
    {
        None,
        NoExperience,
        LowExperience,
        MidExperience,
        HighExperience,
        Expert,
    }

    public enum SelfConfidenceEnum
    {
        None,
        Low,
        Medium,
        High,
        Full,
    }
}
