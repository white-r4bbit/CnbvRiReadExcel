using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class Event
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<Binnacle> Binnacles { get; set; } = new List<Binnacle>();
}
