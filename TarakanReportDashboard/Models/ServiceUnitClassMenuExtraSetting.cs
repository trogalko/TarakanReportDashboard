using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class ServiceUnitClassMenuExtraSetting
{
    public string ServiceUnitId { get; set; } = null!;

    public string ClassId { get; set; } = null!;

    public string? MenuId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
