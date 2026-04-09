using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class ManagedFile
{
    public int Id { get; set; }

    public string SharepointId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Extension { get; set; } = null!;

    public string MimeType { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public int EntityId { get; set; }

    public int SectorId { get; set; }

    public int PeriodId { get; set; }

    public bool Active { get; set; }

    public virtual Entity Entity { get; set; } = null!;

    public virtual Period Period { get; set; } = null!;

    public virtual Sector Sector { get; set; } = null!;
}
