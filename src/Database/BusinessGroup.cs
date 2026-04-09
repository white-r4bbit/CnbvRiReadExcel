using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class BusinessGroup
{
    public int Id { get; set; }

    public string RsaKey { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<Entity> Entities { get; set; } = new List<Entity>();
}
