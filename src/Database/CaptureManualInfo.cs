using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class CaptureManualInfo
{
    public int CaptureId { get; set; }

    public int ManualInfoId { get; set; }

    public virtual Capture Capture { get; set; } = null!;

    public virtual ManualInfoMetadatum ManualInfo { get; set; } = null!;

    public virtual ICollection<ReportCapture> ReportCaptures { get; set; } = new List<ReportCapture>();
}
