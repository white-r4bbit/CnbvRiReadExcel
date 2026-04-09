using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class ExpertAdjustmentLog
{
    public int Id { get; set; }

    public int RiskRateId { get; set; }

    public int UserId { get; set; }

    public double NewValue { get; set; }

    public double? PreviousValue { get; set; }

    public string Justification { get; set; } = null!;

    public DateTime ChangeDate { get; set; }

    public virtual RiskRate RiskRate { get; set; } = null!;

    public virtual Usuario User { get; set; } = null!;
}
