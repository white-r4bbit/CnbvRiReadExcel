using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class Event2
{
    public int Id { get; set; }

    public DateTime Timestamp { get; set; }

    public int SystemId { get; set; }

    public string Instance { get; set; } = null!;

    public int UserId { get; set; }

    public string? Url { get; set; }

    public int ActivityTypeId { get; set; }

    public string? Description { get; set; }

    public string? AdditionalInformation { get; set; }

    public virtual ActivityType ActivityType { get; set; } = null!;

    public virtual Subsystem System { get; set; } = null!;

    public virtual Usuario User { get; set; } = null!;
}
