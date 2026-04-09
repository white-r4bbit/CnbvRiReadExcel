using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class Role
{
    public int Id { get; set; }

    public int SubsistemaId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public bool Activo { get; set; }

    public bool Eliminado { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaActualizacion { get; set; }

    public virtual Subsistema Subsistema { get; set; } = null!;

    public virtual ICollection<Actividad> Actividads { get; set; } = new List<Actividad>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
