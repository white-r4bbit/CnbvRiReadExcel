using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class CeferMetadatum
{
    public int Id { get; set; }

    public int SectorId { get; set; }

    public int Version { get; set; }

    public bool HasAdjustment { get; set; }

    public virtual ExternalSource? ExternalSource { get; set; }

    public virtual ICollection<Matrix> Matrices { get; set; } = new List<Matrix>();

    public virtual Sector Sector { get; set; } = null!;
}
