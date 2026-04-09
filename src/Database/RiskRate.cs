using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class RiskRate
{
    public int Id { get; set; }

    public int MatrixId { get; set; }

    public int InherentRiskId { get; set; }

    public double? Weighting { get; set; }

    public string? InherentRisk { get; set; }

    public double? ExpertAdjustment { get; set; }

    public string? AdjustedInherentRisk { get; set; }

    public bool? FixedEffects { get; set; }

    public string? MitigatingScoreTotal { get; set; }

    public string? NetRisk { get; set; }

    public string? Justification { get; set; }

    public DateTime LastUpdate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public virtual ICollection<ExpertAdjustmentLog> ExpertAdjustmentLogs { get; set; } = new List<ExpertAdjustmentLog>();

    public virtual InherentRisk InherentRiskNavigation { get; set; } = null!;

    public virtual Matrix Matrix { get; set; } = null!;

    public virtual ICollection<MitigatingRate> MitigatingRates { get; set; } = new List<MitigatingRate>();
}
