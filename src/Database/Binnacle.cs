using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class Binnacle
{
    public int Id { get; set; }

    public int EventId { get; set; }

    public DateTime Date { get; set; }

    public int UserId { get; set; }

    public int MatrixId { get; set; }

    public virtual Event Event { get; set; } = null!;

    public virtual Matrix Matrix { get; set; } = null!;

    public virtual Usuario User { get; set; } = null!;
}
