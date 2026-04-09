using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class MatrixParticipant
{
    public int EntityId { get; set; }

    public int UserId { get; set; }

    public int AreaId { get; set; }

    public int RoleId { get; set; }

    public virtual Area Area { get; set; } = null!;

    public virtual Entity Entity { get; set; } = null!;

    public virtual Bpmrole Role { get; set; } = null!;

    public virtual Usuario User { get; set; } = null!;
}
