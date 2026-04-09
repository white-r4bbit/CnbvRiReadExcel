using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class RiskIndicatorMetadatum
{
    public int CeferMetadataId { get; set; }

    public int InherentRiskId { get; set; }

    public int IndicatorId { get; set; }

    public virtual CeferMetadatum CeferMetadata { get; set; } = null!;

    public virtual Indicator Indicator { get; set; } = null!;

    public virtual InherentRisk InherentRisk { get; set; } = null!;
}
