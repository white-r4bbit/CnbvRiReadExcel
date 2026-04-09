using ExcelReader.Models;
using ExcelReader.Services;
using Microsoft.EntityFrameworkCore.Storage;
using ExcelReader.Database;

// ──────────────────────────────────────────────────────────────
//  ExcelReader — Lee registros de un archivo .xlsx
//  Uso: dotnet run -- <ruta-del-archivo.xlsx> [índice-hoja] [fila-encabezado]
// ──────────────────────────────────────────────────────────────

const string AppName = "ExcelReader";

if (args.Length == 0)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"""
        {AppName} — Lectura de archivos Excel (.xlsx)

        Uso:
          dotnet run -- <archivo.xlsx>
          dotnet run -- <archivo.xlsx> <índice-hoja>
          dotnet run -- <archivo.xlsx> <índice-hoja> <fila-encabezado>

        Ejemplos:
          dotnet run -- datos.xlsx
          dotnet run -- datos.xlsx 2          (segunda hoja)
          dotnet run -- datos.xlsx 1 2        (primera hoja, encabezado en fila 2)
        """);
    Console.ResetColor();
    return 1;
}

// ── Parsear argumentos ─────────────────────────────────────────
var filePath = args[0];
var sheetIndex = args.Length >= 2 && int.TryParse(args[1], out var si) ? si : 1;
var headerRow = args.Length >= 3 && int.TryParse(args[2], out var hr) ? hr : 1;

try
{
    Console.WriteLine();
    Console.WriteLine($"Archivo  : {Path.GetFullPath(filePath)}");
    Console.WriteLine($"Hoja     : {sheetIndex}");
    Console.WriteLine($"Encabezado en fila: {headerRow}");
    Console.WriteLine(new string('-', 70));

    // ── Leer registros ─────────────────────────────────────────
    var registros = ExcelService.LeerRegistros(filePath, sheetIndex, headerRow);

    if (registros.Count == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("No se encontraron filas con información.");
        Console.ResetColor();
        return 0;
    }

    Console.WriteLine(new string('-', 107));
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"Proceso completado. {registros.Count} registro(s) cargados en la lista.");
    Console.ResetColor();

    ////UpdateInfoPrudencial(registros);

    // ── Mostrar resultados ─────────────────────────────────────
    //Console.ForegroundColor = ConsoleColor.Cyan;
    //Console.WriteLine($"Total de registros leidos: {registros.Count}");
    //Console.ResetColor();
    //Console.WriteLine();

    //Console.WriteLine(
    //    $"{"#",-4} {"Periodo",-12} {"Casfim",-12} {"CampoClave",-20} {"CampoNombre",-25} {"Comentario",-30}");
    //Console.WriteLine(new string('-', 107));

    //for (int i = 0; i < registros.Count; i++)
    //{
    //    var r = registros[i];
    //    Console.WriteLine(
    //        $"{i + 1,-4} {Truncar(r.Periodo, 12),-12} {Truncar(r.Casfim, 12),-12} " +
    //        $"{Truncar(r.CampoClave, 20),-20} {Truncar(r.CampoNombre, 25),-25} {Truncar(r.Comentario, 30),-30}");
    //}

    Console.WriteLine(new string('-', 107));
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Proceso completado.");
    Console.ResetColor();

    return 0;
}
catch (FileNotFoundException ex)
{
    Imprimir(ex.Message, ConsoleColor.Red);
    return 2;
}
catch (ArgumentOutOfRangeException ex)
{
    Imprimir(ex.Message, ConsoleColor.Red);
    return 3;
}
catch (Exception ex)
{
    Imprimir($"Error inesperado: {ex.Message}", ConsoleColor.Red);
    return 99;
}

static string NormalizarCasfim(string casfim)
{
    if (string.IsNullOrWhiteSpace(casfim))
        throw new ArgumentException("CASFIM vacío.");

    // 1. Limpiar
    casfim = casfim.Trim();

    if (!casfim.All(char.IsDigit))
        throw new ArgumentException("CASFIM debe contener solo dígitos.");

    if (casfim.Length > 6)
        throw new ArgumentException("CASFIM no puede tener más de 6 dígitos.");

    // 2. Padding a 6 dígitos
    casfim = casfim.PadLeft(6, '0');

    // 3. Validar prefijo
    var prefijo = casfim.Substring(0, 3);

    var prefijosValidos = new HashSet<string>
    {
        "040", // Banca múltiple
        "007",
        "027",
        "029",
        "085",
        "013"
    };

    if (!prefijosValidos.Contains(prefijo))
        throw new ArgumentException($"Prefijo CASFIM inválido: {prefijo}");

    return casfim;
}

static void UpdateInfoPrudencial(IEnumerable<RegistroExcel> registros)
{
    var dbConn = new ExcelReader.Database.KardexContext();

    dbConn.Database.BeginTransaction();

    try
    {
        foreach (var registro in registros)
        {
            var casfim = NormalizarCasfim(registro.Casfim);

            var entidad = dbConn.Entities.First(e => e.Casfim == casfim);
            var periodo = dbConn.Periods.First(p => p.Value == registro.Periodo);

            var report = dbConn.Reports.FirstOrDefault(r => r.EntityId == entidad.Id && r.PeriodId == periodo.Id);

            if (report != null)
            {
                var category = dbConn.ReportCategories.FirstOrDefault(c => c.ReportId == report.Id && c.SectorVersionCategory.Category.Prefix == registro.CampoClave);

                if (category != null)
                {
                    category.Comment = registro.Comentario.Trim();
                    ////category.Comment = "Prueba";
                    dbConn.ReportCategories.Update(category);
                }
            }

        }

        dbConn.SaveChanges();
        dbConn.Database.CommitTransaction();
    }
    catch
    {

        dbConn.Database.RollbackTransaction();
    }
}

static string Truncar(string valor, int max) =>
    valor.Length <= max ? valor : valor[..(max - 1)] + "...";

static void Imprimir(string mensaje, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(mensaje);
    Console.ResetColor();
}
