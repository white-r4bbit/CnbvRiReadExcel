using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class DepartmentParticipant
{
    public int InstitutionId { get; set; }

    public int DepartmentId { get; set; }

    public bool CopyInformation { get; set; }

    public virtual Area Department { get; set; } = null!;

    public virtual Entity Institution { get; set; } = null!;
}
