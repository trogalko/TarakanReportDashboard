using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class ServiceUnitItemType
{
    public string ServiceUnitId { get; set; } = null!;

    public string SritemType { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
