using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class AreaSpeciality
{
    public int AreaId { get; set; }

    public int SpecialityId { get; set; }

    public virtual Area Area { get; set; } = null!;

    public virtual ICollection<ManualInfoMetadatum> ManualInfoMetadata { get; set; } = new List<ManualInfoMetadatum>();

    public virtual Speciality Speciality { get; set; } = null!;
}
