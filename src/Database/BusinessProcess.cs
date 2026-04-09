using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class BusinessProcess
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Prefix { get; set; } = null!;

    public virtual ICollection<BusinessProcessRole> BusinessProcessRoles { get; set; } = new List<BusinessProcessRole>();

    public virtual ICollection<ProcessInstance> ProcessInstances { get; set; } = new List<ProcessInstance>();
}
