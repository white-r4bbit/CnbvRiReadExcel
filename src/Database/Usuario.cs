using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class Usuario
{
    public int Id { get; set; }

    public string Expediente { get; set; } = null!;

    public string Alias { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public bool Activo { get; set; }

    public bool Eliminado { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaActualizacion { get; set; }

    public virtual ICollection<Binnacle> Binnacles { get; set; } = new List<Binnacle>();

    public virtual ICollection<EntityProcessRole> EntityProcessRoles { get; set; } = new List<EntityProcessRole>();

    public virtual ICollection<Event2> Event2s { get; set; } = new List<Event2>();

    public virtual ICollection<ExpertAdjustmentLog> ExpertAdjustmentLogs { get; set; } = new List<ExpertAdjustmentLog>();

    public virtual ICollection<InstitutionCategoriesResponsible> InstitutionCategoriesResponsibles { get; set; } = new List<InstitutionCategoriesResponsible>();

    public virtual ICollection<Area> Areas { get; set; } = new List<Area>();

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
}
