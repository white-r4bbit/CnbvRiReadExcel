using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class Evento
{
    public int Id { get; set; }

    public int TipoEventoId { get; set; }

    public int SubsistemaId { get; set; }

    public byte[] Descripcion { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public virtual Subsistema Subsistema { get; set; } = null!;
}
