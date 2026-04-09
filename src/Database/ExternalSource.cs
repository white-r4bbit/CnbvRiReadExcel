using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class ExternalSource
{
    public int Id { get; set; }

    public int CeferMetadataId { get; set; }

    public string TableDescription { get; set; } = null!;

    public virtual CeferMetadatum IdNavigation { get; set; } = null!;
}
