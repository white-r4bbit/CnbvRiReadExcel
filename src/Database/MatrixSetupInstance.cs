using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class MatrixSetupInstance
{
    public int Id { get; set; }

    public int EntityId { get; set; }

    public int PeriodId { get; set; }

    public string ProcessInstanceId { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public bool Active { get; set; }

    public virtual Entity Entity { get; set; } = null!;

    public virtual Period Period { get; set; } = null!;
}
