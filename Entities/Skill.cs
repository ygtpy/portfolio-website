using System;
using System.Collections.Generic;

namespace AkademiQPortfolio.Entities;

public partial class Skill
{
    public int SkillId { get; set; }

    public string? SkillTitle { get; set; }

    public string? Knowledge { get; set; }

    public string? Language { get; set; }

    public byte? SkillValue { get; set; }
    public byte? LanguagePercentage { get; set; }
}
