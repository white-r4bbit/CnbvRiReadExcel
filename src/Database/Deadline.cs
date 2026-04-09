using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class Deadline
{
    public int Id { get; set; }

    public int PeriodId { get; set; }

    public string Deadline1 { get; set; } = null!;

    public virtual Period Period { get; set; } = null!;
}
