using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class ReportCapture
{
    public int Id { get; set; }

    public int ReportId { get; set; }

    public int CapturesId { get; set; }

    public int ManualInfoId { get; set; }

    public string? CaptureValue { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? LastUpdate { get; set; }

    public virtual CaptureManualInfo CaptureManualInfo { get; set; } = null!;

    public virtual Report Report { get; set; } = null!;
}
