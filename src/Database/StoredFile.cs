using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class StoredFile
{
    public Guid SharepointId { get; set; }

    public int InstitutionId { get; set; }

    public int PeriodId { get; set; }

    public string Score { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Extension { get; set; } = null!;

    public string MimeType { get; set; } = null!;

    public DateTime UploadDate { get; set; }

    public string UploadedBy { get; set; } = null!;

    public bool Stored { get; set; }

    public virtual Entity Institution { get; set; } = null!;

    public virtual Period Period { get; set; } = null!;
}
