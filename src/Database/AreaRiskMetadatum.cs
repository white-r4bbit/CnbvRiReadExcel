using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class AreaRiskMetadatum
{
    public int AreaId { get; set; }

    public int InherentRiskId { get; set; }

    public virtual Area Area { get; set; } = null!;

    public virtual InherentRisk InherentRisk { get; set; } = null!;
}
