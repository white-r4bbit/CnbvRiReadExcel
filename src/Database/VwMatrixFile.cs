using System;
using System.Collections.Generic;

namespace ExcelReader.Database;

public partial class VwMatrixFile
{
    public string Period { get; set; } = null!;

    public string? Casfim { get; set; }

    public string Department { get; set; } = null!;

    public int Id { get; set; }

    public string SharepointId { get; set; } = null!;

    public int MatrixId { get; set; }

    public string Name { get; set; } = null!;

    public string MimeType { get; set; } = null!;

    public string Extension { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public int? AreaId { get; set; }
}
