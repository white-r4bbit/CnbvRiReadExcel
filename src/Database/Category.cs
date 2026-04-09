using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class Category
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public string Prefix { get; set; } = null!;

    public int SheetNumber { get; set; }

    public string? DgaiKey { get; set; }

    public string? CeferRisk { get; set; }

    public virtual ICollection<SectorVersionCategory> SectorVersionCategories { get; set; } = new List<SectorVersionCategory>();
}
