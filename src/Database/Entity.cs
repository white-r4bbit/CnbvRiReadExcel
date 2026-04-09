using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class Entity
{
    public int Id { get; set; }

    public int? PesKey { get; set; }

    public string? Casfim { get; set; }

    public int BusinessGroupId { get; set; }

    public bool Active { get; set; }

    public virtual BusinessGroup BusinessGroup { get; set; } = null!;

    public virtual ICollection<DepartmentParticipant> DepartmentParticipants { get; set; } = new List<DepartmentParticipant>();

    public virtual ICollection<DynamicRisksConfiguration> DynamicRisksConfigurations { get; set; } = new List<DynamicRisksConfiguration>();

    public virtual ICollection<EntityProcessRole> EntityProcessRoles { get; set; } = new List<EntityProcessRole>();

    public virtual ICollection<InstitutionCategoriesResponsible> InstitutionCategoriesResponsibles { get; set; } = new List<InstitutionCategoriesResponsible>();

    public virtual ICollection<ManagedFile> ManagedFiles { get; set; } = new List<ManagedFile>();

    public virtual ICollection<Matrix> Matrices { get; set; } = new List<Matrix>();

    public virtual ICollection<MatrixSetupInstance> MatrixSetupInstances { get; set; } = new List<MatrixSetupInstance>();

    public virtual ICollection<ProcessInstance> ProcessInstances { get; set; } = new List<ProcessInstance>();

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();

    public virtual ICollection<StoredFile> StoredFiles { get; set; } = new List<StoredFile>();

    public virtual ICollection<SystemicInstitution> SystemicInstitutions { get; set; } = new List<SystemicInstitution>();
}
