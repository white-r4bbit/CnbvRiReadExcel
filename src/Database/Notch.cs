using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class Notch
{
    public int Id { get; set; }

    public int ControlNumber { get; set; }

    public decimal? InitialRange { get; set; }

    public decimal? FinalRange { get; set; }

    public string FinalNotch { get; set; } = null!;

    public int Adjustment { get; set; }

    public decimal? InherentRiskPercentage { get; set; }

    public decimal? MitigatingPercentage { get; set; }

    public short? FortressAdjustment { get; set; }

    public int NewFortressAdjustment { get; set; }
}
