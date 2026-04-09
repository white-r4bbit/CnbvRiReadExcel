using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class Position
{
    public int Id { get; set; }

    public string BpmName { get; set; } = null!;

    public string GuidKey { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int AreaId { get; set; }

    public int SubSystemId { get; set; }

    public virtual Area Area { get; set; } = null!;

    public virtual Subsystem SubSystem { get; set; } = null!;
}
