using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class BpmRole1
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Prefix { get; set; } = null!;

    public virtual ICollection<BusinessProcessRole> BusinessProcessRoles { get; set; } = new List<BusinessProcessRole>();

    public virtual ICollection<InstitutionCategoriesResponsible> InstitutionCategoriesResponsibles { get; set; } = new List<InstitutionCategoriesResponsible>();
}
