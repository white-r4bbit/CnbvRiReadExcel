namespace ExcelReader.Models;

/// <summary>
/// Representa una fila con información del archivo Excel.
/// Columnas: A=Periodo, B=Casfim, C=CampoClave, D=CampoNombre, E=Comentario
/// </summary>
public sealed record RegistroExcel(
    string Periodo,
    string Casfim,
    string CampoClave,
    string CampoNombre,
    string Comentario
)
{
    public override string ToString() =>
        $"[Periodo={Periodo} | Casfim={Casfim} | CampoClave={CampoClave} | " +
        $"CampoNombre={CampoNombre} | Comentario={Comentario}]";
}
