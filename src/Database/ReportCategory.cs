using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class ReportCategory
{
    public int Id { get; set; }

    public int ReportId { get; set; }

    public int SectorVersionId { get; set; }

    public int CategoryId { get; set; }

    public string? Comment { get; set; }

    public bool IsVisible { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? CeferScore { get; set; }

    public virtual Report Report { get; set; } = null!;

    public virtual SectorVersionCategory SectorVersionCategory { get; set; } = null!;
}
