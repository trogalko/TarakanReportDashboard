using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class DashboardDefault
{
    public int DashboardDefaultId { get; set; }

    public string LoginName { get; set; } = null!;

    public int? SqlserverId { get; set; }

    public int DashboardLayoutId { get; set; }
}
