using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class ReportUpdate
{
    public int Id { get; set; }

    public int ReportId { get; set; }

    public DateTime UpdatedOn { get; set; }

    public string EstablishedBy { get; set; } = null!;

    public virtual Report Report { get; set; } = null!;
}
