using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class VwMatrixRiskConfiguration
{
    public string? Casfim { get; set; }

    public string Department { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int DepartmentId { get; set; }

    public int RiskId { get; set; }

    public int InstitutionId { get; set; }

    public bool IsSupervised { get; set; }

    public bool IsEvaluated { get; set; }

    public bool IsConfigurable { get; set; }
}
