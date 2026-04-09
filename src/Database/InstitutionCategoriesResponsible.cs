using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class InstitutionCategoriesResponsible
{
    public int InstitutionId { get; set; }

    public int SectorVersionId { get; set; }

    public int CategoryId { get; set; }

    public int BpmRoleId { get; set; }

    public int UserId { get; set; }

    public virtual BpmRole1 BpmRole { get; set; } = null!;

    public virtual Entity Institution { get; set; } = null!;

    public virtual SectorVersionCategory SectorVersionCategory { get; set; } = null!;

    public virtual Usuario User { get; set; } = null!;
}
