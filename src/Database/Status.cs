using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class Status
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
}
