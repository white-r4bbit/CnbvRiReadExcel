using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class Matrix
{
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

    public virtual ICollection<Binnacle> Binnacles { get; set; } = new List<Binnacle>();

    public virtual CeferMetadatum CeferMetadata { get; set; } = null!;

    public virtual Entity Entity { get; set; } = null!;

    public virtual ICollection<MatrixFile> MatrixFiles { get; set; } = new List<MatrixFile>();

    public virtual MatrixType MatrixType { get; set; } = null!;

    public virtual Period Period { get; set; } = null!;

    public virtual RateStatus RateStatus { get; set; } = null!;

    public virtual ICollection<RiskRate> RiskRates { get; set; } = new List<RiskRate>();
}
