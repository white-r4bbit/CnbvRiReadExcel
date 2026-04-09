using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class ManualInfoMetadatum
{
    public int Id { get; set; }

    public int AreaId { get; set; }

    public int SpecialityId { get; set; }

    public int Version { get; set; }

    public virtual AreaSpeciality AreaSpeciality { get; set; } = null!;

    public virtual ICollection<CaptureManualInfo> CaptureManualInfos { get; set; } = new List<CaptureManualInfo>();

    public virtual ICollection<SectorVersion> SectorVersions { get; set; } = new List<SectorVersion>();
}
