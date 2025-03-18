﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class Tag
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double? TagScaleFactor { get; set; }

    public virtual ICollection<CustomCounterDefinition> Metrics { get; set; } = new List<CustomCounterDefinition>();

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();

    public virtual ICollection<MonitoredSqlserver> Sqlservers { get; set; } = new List<MonitoredSqlserver>();

    public virtual ICollection<CustomDashboardWidget> Widgets { get; set; } = new List<CustomDashboardWidget>();
}
