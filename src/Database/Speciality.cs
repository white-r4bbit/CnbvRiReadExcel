using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class Speciality
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Prefix { get; set; } = null!;

    public virtual ICollection<AreaSpeciality> AreaSpecialities { get; set; } = new List<AreaSpeciality>();
}
