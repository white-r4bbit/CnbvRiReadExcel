using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class RiskPropertyMetadatum
{
    public int InherentRiskId { get; set; }

    public int RiskPropertyId { get; set; }

    public virtual InherentRisk InherentRisk { get; set; } = null!;

    public virtual RiskProperty RiskProperty { get; set; } = null!;
}
