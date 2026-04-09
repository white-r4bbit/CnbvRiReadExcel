using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class Subsystem
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public virtual ICollection<Event2> Event2s { get; set; } = new List<Event2>();

    public virtual ICollection<Position> Positions { get; set; } = new List<Position>();

    public virtual ICollection<Sector> Sectors { get; set; } = new List<Sector>();
}
