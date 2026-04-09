using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class InherentRiskMetadatum
{
    public int CeferMetadataId { get; set; }

    public int InherentRiskId { get; set; }

    public int PresentationOrder { get; set; }

    public virtual CeferMetadatum CeferMetadata { get; set; } = null!;

    public virtual InherentRisk InherentRisk { get; set; } = null!;
}
