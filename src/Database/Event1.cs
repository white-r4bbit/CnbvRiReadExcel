using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class Event1
{
    public int Id { get; set; }

    public DateTime Timestamp { get; set; }

    public string Instance { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Provider { get; set; } = null!;
}
