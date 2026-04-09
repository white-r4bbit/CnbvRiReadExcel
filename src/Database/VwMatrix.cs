using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class VwMatrix
{
    public string Period { get; set; } = null!;

    public string? Casfim { get; set; }

    public int Id { get; set; }

    public int EntityId { get; set; }

    public int CeferMetadataId { get; set; }

    public int PeriodId { get; set; }

    public int RateStatusId { get; set; }

    public DateTime Date { get; set; }

    public string? Justification { get; set; }

    public string? ScoreTotal { get; set; }

    public int? InStockMarket { get; set; }

    public int? MainOffice { get; set; }

    public int? Important { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime LastUpdate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public int MatrixTypeId { get; set; }

    public int Version { get; set; }

    public int? IntScoreTotal { get; set; }
}
