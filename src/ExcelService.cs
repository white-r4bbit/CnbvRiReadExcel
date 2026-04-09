using ClosedXML.Excel;
using ExcelReader.Models;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ExcelReader.Services;

public static class ExcelService
{
    /// <summary>
    /// Lee la primera hoja del archivo Excel especificado y devuelve la lista de registros
    /// cuyas columnas A-E contengan al menos un valor no vacío.
    /// </summary>
    /// <param name="filePath">Ruta absoluta o relativa al archivo .xlsx</param>
    /// <param name="sheetIndex">Índice (base 1) de la hoja a leer. Por defecto la primera.</param>
    /// <param name="headerRow">Fila que contiene los encabezados (se omite). Por defecto la fila 1.</param>
    public static IReadOnlyList<RegistroExcel> LeerRegistros(
        string filePath,
        int sheetIndex = 1,
        int headerRow = 1)
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException($"No se encontró el archivo: {filePath}");

        using var workbook = new XLWorkbook(filePath);

        if (sheetIndex < 1 || sheetIndex > workbook.Worksheets.Count)
            throw new ArgumentOutOfRangeException(nameof(sheetIndex),
                $"El índice de hoja {sheetIndex} no existe. El libro tiene {workbook.Worksheets.Count} hoja(s).");

        var sheet = workbook.Worksheet(sheetIndex);
        var registros = new List<RegistroExcel>();

        // Determinar el último número de fila con datos
        var lastRow = sheet.LastRowUsed()?.RowNumber() ?? 0;

        for (int row = headerRow + 1; row <= lastRow; row++)
        {
            var periodo = ObtenerTexto(sheet, row, 1); // A
            var casfim = ObtenerTexto(sheet, row, 2); // B
            var campoClave = ObtenerTexto(sheet, row, 3); // C
            var campoNombre = ObtenerTexto(sheet, row, 4); // D
            var comentario = ObtenerTexto(sheet, row, 5); // E

            // Solo procesar filas que tengan al menos un campo con datos
            if (string.IsNullOrWhiteSpace(periodo) &&
                string.IsNullOrWhiteSpace(casfim) &&
                string.IsNullOrWhiteSpace(campoClave) &&
                string.IsNullOrWhiteSpace(campoNombre) &&
                string.IsNullOrWhiteSpace(comentario))
            {
                continue;
            }

            registros.Add(new RegistroExcel(
                Periodo: periodo,
                Casfim: casfim,
                CampoClave: campoClave,
                CampoNombre: campoNombre,
                Comentario: comentario
            ));
        }

        return registros.AsReadOnly();
    }

    public static IReadOnlyList<RegistroExcel> LeerRegistrosEspecializadas(
        string filePath,
        int sheetIndex = 1,
        int headerRow = 1)
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException($"No se encontró el archivo: {filePath}");

        using var workbook = new XLWorkbook(filePath);

        if (sheetIndex < 1 || sheetIndex > workbook.Worksheets.Count)
            throw new ArgumentOutOfRangeException(nameof(sheetIndex),
                $"El índice de hoja {sheetIndex} no existe. El libro tiene {workbook.Worksheets.Count} hoja(s).");

        var sheet = workbook.Worksheet(sheetIndex);
        var registros = new List<RegistroExcel>();

        // Determinar el último número de fila con datos
        var lastRow = sheet.LastRowUsed()?.RowNumber() ?? 0;

        for (int row = headerRow + 1; row <= lastRow; row++)
        {
            var periodo = ObtenerTexto(sheet, row, 1); // A
            var casfim = ObtenerTexto(sheet, row, 2); // B
            var especialidad = ObtenerTexto(sheet, row, 3); // C
            var idCaptura = ObtenerTexto(sheet, row, 4); // D
            var idManualInfo = ObtenerTexto(sheet, row, 5); // E
            var campoClave = ObtenerTexto(sheet, row, 6); // E
            var campoNombre = ObtenerTexto(sheet, row, 7); // E
            var formato = ObtenerTexto(sheet, row, 8); // E
            var valor = ObtenerTexto(sheet, row, 9); // E

            // Solo procesar filas que tengan al menos un campo con datos
            if (string.IsNullOrWhiteSpace(periodo) &&
                string.IsNullOrWhiteSpace(casfim) &&
                string.IsNullOrWhiteSpace(especialidad) &&
                string.IsNullOrWhiteSpace(campoClave) &&
                string.IsNullOrWhiteSpace(formato) &&
                string.IsNullOrWhiteSpace(valor))
            {
                continue;
            }

            registros.Add(new RegistroExcelEspecializada(
                Periodo: periodo,
                Casfim: casfim,
                Especialidad: especialidad,
                IdCaptura: int.TryParse(idCaptura, out var idCap) ? idCap : 0,
                IdManualInfo: int.TryParse(idManualInfo, out var idMan) ? idMan : 0,
                CampoClave: campoClave,
                CampoNombre: campoNombre,
                Formato: formato,
                Valor: valor
            ));
        }

        return registros.AsReadOnly();
    }

    private static void ValidarCampo(string campoClave, string formato, string valor, int row)
    {
        if (string.IsNullOrWhiteSpace(valor))
            return;

        switch (formato?.Trim().ToUpperInvariant())
        {
            case "DD/MM/AAAA":
                if (!DateTime.TryParseExact(valor, "dd/MM/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None, out _))
                {
                    throw new FormatException(
                        $"Fila {row}: El campo '{campoClave}' debe tener formato DD/MM/AAAA. Valor: '{valor}'");
                }
                break;

            case "SÍ|NO":
            case "SI|NO":
                if (!EsSiNo(valor))
                {
                    throw new FormatException(
                        $"Fila {row}: El campo '{campoClave}' debe ser 'Sí' o 'No'. Valor: '{valor}'");
                }
                break;

            case "NOTCH":
                if (!EsNotch(valor))
                {
                    throw new FormatException(
                        $"Fila {row}: El campo '{campoClave}' debe ser tipo Notch (ej: 1, 1+, 1-). Valor: '{valor}'");
                }
                break;

            case "TEXTO SIN FORMATO":
            default:
                // No validar
                break;
        }
    }

    private static bool EsSiNo(string valor)
    {
        var v = valor.Trim().ToUpperInvariant();
        return v == "SI" || v == "SÍ" || v == "NO";
    }

    private static bool EsNotch(string valor)
    {
        // Ejemplos válidos: 1, 1+, 1-, 10, 10+, 10-
        return Regex.IsMatch(valor.Trim(), @"^\d+(\+|-)?$");
    }

    // Obtiene el valor de una celda como string limpio, manejando distintos tipos de celda.
    private static string ObtenerTexto(IXLWorksheet sheet, int row, int col)
    {
        var cell = sheet.Cell(row, col);

        if (cell.IsEmpty())
            return string.Empty;

        return cell.DataType switch
        {
            XLDataType.DateTime => cell.GetDateTime().ToString("yyyy-MM-dd"),
            XLDataType.Number => cell.GetDouble().ToString(),
            XLDataType.Boolean => cell.GetBoolean().ToString(),
            _ => cell.GetString().Trim()
        };
    }
}
