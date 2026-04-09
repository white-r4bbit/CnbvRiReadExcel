using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class Period
{
    public int Id { get; set; }

    public string Value { get; set; } = null!;

    public string? Description { get; set; }

    public int? Year { get; set; }

    public int? Month { get; set; }

    public virtual ICollection<Deadline> Deadlines { get; set; } = new List<Deadline>();

    public virtual ICollection<ManagedFile> ManagedFiles { get; set; } = new List<ManagedFile>();

    public virtual ICollection<Matrix> Matrices { get; set; } = new List<Matrix>();

    public virtual ICollection<MatrixSetupInstance> MatrixSetupInstances { get; set; } = new List<MatrixSetupInstance>();

    public virtual ICollection<ProcessInstance> ProcessInstances { get; set; } = new List<ProcessInstance>();

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();

    public virtual ICollection<StoredFile> StoredFiles { get; set; } = new List<StoredFile>();

    public virtual ICollection<UnmanagedSectorFile> UnmanagedSectorFiles { get; set; } = new List<UnmanagedSectorFile>();
}
