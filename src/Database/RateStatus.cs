using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class RateStatus
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<Matrix> Matrices { get; set; } = new List<Matrix>();
}
