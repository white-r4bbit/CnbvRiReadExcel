using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class ComentariosReporteInstitucional
{
    public string Periodo { get; set; } = null!;

    public string? Institucion { get; set; }

    public string Rubro { get; set; } = null!;

    public string? Dgai { get; set; }

    public string? Comentario { get; set; }
}
