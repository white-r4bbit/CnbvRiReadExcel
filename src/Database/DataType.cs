using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class DataType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Capture> Captures { get; set; } = new List<Capture>();
}
