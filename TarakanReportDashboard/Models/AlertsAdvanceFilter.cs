using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class AlertsAdvanceFilter
{
    public string FilterName { get; set; } = null!;

    public string Config { get; set; } = null!;
}
