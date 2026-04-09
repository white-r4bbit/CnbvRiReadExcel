using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class Sector
{
    public int Id { get; set; }

    public int DgaiKey { get; set; }

    public virtual ICollection<CeferMetadatum> CeferMetadata { get; set; } = new List<CeferMetadatum>();

    public virtual ICollection<ManagedFile> ManagedFiles { get; set; } = new List<ManagedFile>();

    public virtual ICollection<SectorVersion> SectorVersions { get; set; } = new List<SectorVersion>();

    public virtual UnmanagedSector? UnmanagedSector { get; set; }

    public virtual ICollection<Subsystem> Subsystems { get; set; } = new List<Subsystem>();
}
