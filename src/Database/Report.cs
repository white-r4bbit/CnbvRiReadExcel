using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class Report
{
    public int Id { get; set; }

    public int EntityId { get; set; }

    public int PeriodId { get; set; }

    public int StatusId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime LastUpdate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateOnly? CapitalizationReleaseDate { get; set; }

    public virtual Entity Entity { get; set; } = null!;

    public virtual ExportedFile? ExportedFile { get; set; }

    public virtual Period Period { get; set; } = null!;

    public virtual ICollection<ReportCapture> ReportCaptures { get; set; } = new List<ReportCapture>();

    public virtual ICollection<ReportCategory> ReportCategories { get; set; } = new List<ReportCategory>();

    public virtual ICollection<ReportUpdate> ReportUpdates { get; set; } = new List<ReportUpdate>();

    public virtual Status Status { get; set; } = null!;
}
