using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class SectorVersion
{
    public int Id { get; set; }

    public int SectorId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public virtual Sector Sector { get; set; } = null!;

    public virtual ICollection<SectorVersionCategory> SectorVersionCategories { get; set; } = new List<SectorVersionCategory>();

    public virtual ICollection<ManualInfoMetadatum> ManualInfos { get; set; } = new List<ManualInfoMetadatum>();
}
