using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class Area
{
    public int Id { get; set; }

    public string PesKey { get; set; } = null!;

    public int TypeId { get; set; }

    public virtual ICollection<AreaSpeciality> AreaSpecialities { get; set; } = new List<AreaSpeciality>();

    public virtual ICollection<DepartmentParticipant> DepartmentParticipants { get; set; } = new List<DepartmentParticipant>();

    public virtual ICollection<DynamicRisksConfiguration> DynamicRisksConfigurations { get; set; } = new List<DynamicRisksConfiguration>();

    public virtual ICollection<MatrixFile> MatrixFiles { get; set; } = new List<MatrixFile>();

    public virtual ICollection<Position> Positions { get; set; } = new List<Position>();

    public virtual AreaType Type { get; set; } = null!;

    public virtual ICollection<Usuario> Users { get; set; } = new List<Usuario>();
}
