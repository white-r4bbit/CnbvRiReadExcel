using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class Indicator
{
    public int Id { get; set; }

    public string Prefix { get; set; } = null!;

    public string Name { get; set; } = null!;
}
