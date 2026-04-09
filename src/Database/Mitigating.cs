using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class Mitigating
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public double? Weighting { get; set; }

    public virtual ICollection<MitigatingRate> MitigatingRates { get; set; } = new List<MitigatingRate>();
}
