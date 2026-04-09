using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class PageAccess
{
    public int Id { get; set; }

    public string Url { get; set; } = null!;

    public DateTime Timestamp { get; set; }

    public int UserId { get; set; }
}
