using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class PrescriptionQueueDisplay
{
    public string? Ip { get; set; }

    public string? ServiceUnitId { get; set; }

    public bool? IsComplete { get; set; }

    public int? CurrentPage { get; set; }
}
