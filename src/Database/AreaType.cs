using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class AreaType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public virtual ICollection<Area> Areas { get; set; } = new List<Area>();
}
