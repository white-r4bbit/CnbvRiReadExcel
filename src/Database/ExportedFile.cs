using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class ExportedFile
{
    public int ReportId { get; set; }

    public string SharepointId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Extension { get; set; } = null!;

    public string MimeType { get; set; } = null!;

    public DateTime UploadDate { get; set; }

    public string UploadedBy { get; set; } = null!;

    public bool Active { get; set; }

    public virtual Report Report { get; set; } = null!;
}
