using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class Subsistema
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public bool Activo { get; set; }

    public bool Eliminado { get; set; }

    public DateTime FechaActualizacion { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string NombreSistema { get; set; } = null!;

    public virtual ICollection<Actividad> Actividads { get; set; } = new List<Actividad>();

    public virtual ICollection<Configuracion> Configuracions { get; set; } = new List<Configuracion>();

    public virtual ICollection<Evento> Eventos { get; set; } = new List<Evento>();

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();

    public virtual ICollection<TipoEvento> TipoEventos { get; set; } = new List<TipoEvento>();
}
