using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class VwMatrixMitigatingRate
{
    public string Periodo { get; set; } = null!;

    public string? Casfim { get; set; }

    public string InherentRisk { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Id { get; set; }

    public int RiskRateId { get; set; }

    public int MitigatingId { get; set; }

    public string? Notch { get; set; }

    public string? Justification { get; set; }

    public int? Movement { get; set; }

    public DateTime LastUpdate { get; set; }

    public string UpdatedBy { get; set; } = null!;
}
