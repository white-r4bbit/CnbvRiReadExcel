using ClosedXML.Excel;
using ExcelReader.Models;

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
            var periodo     = ObtenerTexto(sheet, row, 1); // A
            var casfim      = ObtenerTexto(sheet, row, 2); // B
            var campoClave  = ObtenerTexto(sheet, row, 3); // C
            var campoNombre = ObtenerTexto(sheet, row, 4); // D
            var comentario  = ObtenerTexto(sheet, row, 5); // E

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
                Periodo:     periodo,
                Casfim:      casfim,
                CampoClave:  campoClave,
                CampoNombre: campoNombre,
                Comentario:  comentario
            ));
        }

        return registros.AsReadOnly();
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
            XLDataType.Number   => cell.GetDouble().ToString(),
            XLDataType.Boolean  => cell.GetBoolean().ToString(),
            _                   => cell.GetString().Trim()
        };
    }
}
