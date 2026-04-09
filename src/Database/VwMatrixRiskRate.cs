using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class VwMatrixRiskRate
{
    public string Periodo { get; set; } = null!;

    public string? Casfim { get; set; }

    public string Name { get; set; } = null!;

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
}
