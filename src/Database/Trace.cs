using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class Trace
{
    public long TraceId { get; set; }

    public string InstanceName { get; set; } = null!;

    public Guid ProviderId { get; set; }

    public string ProviderName { get; set; } = null!;

    public int EventId { get; set; }

    public long EventKeywords { get; set; }

    public int Level { get; set; }

    public int Opcode { get; set; }

    public int Task { get; set; }

    public DateTimeOffset Timestamp { get; set; }

    public int Version { get; set; }

    public string? FormattedMessage { get; set; }

    public string? Payload { get; set; }

    public Guid? ActivityId { get; set; }

    public Guid? RelatedActivityId { get; set; }

    public int? ProcessId { get; set; }

    public int? ThreadId { get; set; }
}
