using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class MultipleOption
{
    public int Id { get; set; }

    public int CaptureId { get; set; }

    public string MultipleValue { get; set; } = null!;

    public virtual Capture Capture { get; set; } = null!;
}
