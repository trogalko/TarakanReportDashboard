﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class CustomDashboardMatchType
{
    public int MatchId { get; set; }

    public string MatchType { get; set; } = null!;

    public virtual ICollection<CustomDashboardWidget> CustomDashboardWidgets { get; set; } = new List<CustomDashboardWidget>();
}
