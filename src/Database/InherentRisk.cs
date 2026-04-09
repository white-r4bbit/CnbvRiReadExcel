using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class InherentRisk
{
    public int Id { get; set; }

    public string Prefix { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int? ParentId { get; set; }

    public bool IsEditable { get; set; }

    public bool IsVisible { get; set; }

    public bool ContainsTotal { get; set; }

    public bool HelpsCalculations { get; set; }

    public bool EditMitigatings { get; set; }

    public bool IsTechnicalArea { get; set; }

    public bool EvaluateMitigatingScoreTotal { get; set; }

    public bool EvaluateNetRisk { get; set; }

    public bool EvaluateAdjustedInherentrisk { get; set; }

    public string? NewPrefix { get; set; }

    public int Deep { get; set; }

    public virtual ICollection<DynamicRisksConfiguration> DynamicRisksConfigurations { get; set; } = new List<DynamicRisksConfiguration>();

    public virtual ICollection<RiskRate> RiskRates { get; set; } = new List<RiskRate>();
}
