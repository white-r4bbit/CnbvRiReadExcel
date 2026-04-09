using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class MitigatingRate
{
    public int Id { get; set; }

    public int RiskRateId { get; set; }

    public int MitigatingId { get; set; }

    public string? Notch { get; set; }

    public string? Justification { get; set; }

    public int? Movement { get; set; }

    public DateTime LastUpdate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public virtual Mitigating Mitigating { get; set; } = null!;

    public virtual RiskRate RiskRate { get; set; } = null!;
}
