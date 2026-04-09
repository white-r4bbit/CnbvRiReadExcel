using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class UnmanagedSector
{
    public int SectorId { get; set; }

    public virtual Sector Sector { get; set; } = null!;

    public virtual ICollection<UnmanagedSectorFile> UnmanagedSectorFiles { get; set; } = new List<UnmanagedSectorFile>();
}
