using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class MitigatingMetadatum
{
    public int CeferMetadataId { get; set; }

    public int MitigatingId { get; set; }

    public virtual CeferMetadatum CeferMetadata { get; set; } = null!;

    public virtual Mitigating Mitigating { get; set; } = null!;
}
