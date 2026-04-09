using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class EntityProcessRole
{
    public int BpmRoleId { get; set; }

    public int BusinessProcessId { get; set; }

    public int EntityId { get; set; }

    public int UserId { get; set; }

    public int Department { get; set; }

    public virtual BusinessProcessRole BusinessProcessRole { get; set; } = null!;

    public virtual Entity Entity { get; set; } = null!;

    public virtual Usuario User { get; set; } = null!;
}
