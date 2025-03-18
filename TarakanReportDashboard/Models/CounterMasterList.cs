using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class CounterMasterList
{
    public int Id { get; set; }

    public string CounterName { get; set; } = null!;

    public string? CounterFriendlyName { get; set; }

    public int? CounterType { get; set; }

    public bool? AvailableInCustomReport { get; set; }
}
