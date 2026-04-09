using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class UnmanagedSectorFile
{
    public Guid SharepointId { get; set; }

    public int SectorId { get; set; }

    public int PeriodId { get; set; }

    public string Name { get; set; } = null!;

    public string Extension { get; set; } = null!;

    public string MimeType { get; set; } = null!;

    public DateTime UploadDate { get; set; }

    public string UploadedBy { get; set; } = null!;

    public decimal Size { get; set; }

    public bool Active { get; set; }

    public virtual Period Period { get; set; } = null!;

    public virtual UnmanagedSector Sector { get; set; } = null!;
}
