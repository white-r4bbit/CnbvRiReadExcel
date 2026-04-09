using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class BusinessProcessRole
{
    public int BpmRoleId { get; set; }

    public int BusinessProcessId { get; set; }

    public virtual BpmRole1 BpmRole { get; set; } = null!;

    public virtual BusinessProcess BusinessProcess { get; set; } = null!;

    public virtual ICollection<EntityProcessRole> EntityProcessRoles { get; set; } = new List<EntityProcessRole>();
}
