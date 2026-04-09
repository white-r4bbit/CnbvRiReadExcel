using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class VwMatrixProcessInstance
{
    public string Period { get; set; } = null!;

    public string? Casfim { get; set; }

    public int Id { get; set; }

    public int EntityId { get; set; }

    public int PeriodId { get; set; }

    public string ProcessInstanceId { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public bool Active { get; set; }
}
