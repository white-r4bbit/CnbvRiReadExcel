using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class Capture
{
    public int Id { get; set; }

    public int DataTypeId { get; set; }

    public string Prefix { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int SheetNumber { get; set; }

    public bool Editable { get; set; }

    public string? Tooltip { get; set; }

    public virtual ICollection<CaptureManualInfo> CaptureManualInfos { get; set; } = new List<CaptureManualInfo>();

    public virtual DataType DataType { get; set; } = null!;

    public virtual ICollection<MultipleOption> MultipleOptions { get; set; } = new List<MultipleOption>();
}
