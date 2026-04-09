using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class ActivityType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Event2> Event2s { get; set; } = new List<Event2>();
}
