using System;
using System.Collections.Generic;
using System.Text;

namespace Carver.Models
{
    internal enum UserRole
    {
        Employee,
        Administrator
    }

    internal enum CarverModelType
    {
        Base,
        RPlus, // R+
        Range,
        SPlus, // S+
        Sport
    }

    internal enum ExperienceAnswer
    {
        Disagree = 1,
        Neutral = 2,
        Agree = 3
    }
}
