using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class ProcessInstance
{
    public string Id { get; set; } = null!;

    public int EntityId { get; set; }

    public int PeriodId { get; set; }

    public int BusinessProcessId { get; set; }

    public DateTime CreatedDate { get; set; }

    public bool Active { get; set; }

    public virtual BusinessProcess BusinessProcess { get; set; } = null!;

    public virtual Entity Entity { get; set; } = null!;

    public virtual Period Period { get; set; } = null!;
}
