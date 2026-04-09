using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class SectorVersionCategory
{
    public int SectorVersionId { get; set; }

    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<InstitutionCategoriesResponsible> InstitutionCategoriesResponsibles { get; set; } = new List<InstitutionCategoriesResponsible>();

    public virtual ICollection<ReportCategory> ReportCategories { get; set; } = new List<ReportCategory>();

    public virtual SectorVersion SectorVersion { get; set; } = null!;
}
