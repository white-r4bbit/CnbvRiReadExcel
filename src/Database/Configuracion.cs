using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class Configuracion
{
    public int Id { get; set; }

    public string Key { get; set; } = null!;

    public string Value { get; set; } = null!;

    public int SystemId { get; set; }

    public virtual Subsistema System { get; set; } = null!;
}
