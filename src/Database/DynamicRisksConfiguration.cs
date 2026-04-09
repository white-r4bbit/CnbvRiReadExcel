using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class DynamicRisksConfiguration
{
    public int DepartmentId { get; set; }

    public int RiskId { get; set; }

    public int InstitutionId { get; set; }

    public bool IsSupervised { get; set; }

    public bool IsEvaluated { get; set; }

    public bool IsConfigurable { get; set; }

    public virtual Area Department { get; set; } = null!;

    public virtual Entity Institution { get; set; } = null!;

    public virtual InherentRisk Risk { get; set; } = null!;
}
