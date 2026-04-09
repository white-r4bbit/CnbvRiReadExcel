using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class VwMatrixParticipant
{
    public string? Casfim { get; set; }

    public string Department { get; set; } = null!;

    public string User { get; set; } = null!;

    public string Role { get; set; } = null!;

    public int EntityId { get; set; }

    public int UserId { get; set; }

    public int AreaId { get; set; }

    public int RoleId { get; set; }
}
