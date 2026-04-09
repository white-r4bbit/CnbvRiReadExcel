using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class SystemicInstitution
{
    public int Id { get; set; }

    public int EntityId { get; set; }

    public int SystemicOrder { get; set; }

    public virtual Entity Entity { get; set; } = null!;
}
