using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class ServerActivity
{
    public int SqlserverId { get; set; }

    public DateTime UtccollectionDateTime { get; set; }

    public string? StateOverview { get; set; }

    public byte[]? SystemProcesses { get; set; }

    public byte[]? SessionList { get; set; }

    public byte[]? LockStatistics { get; set; }

    public byte[]? LockList { get; set; }

    public int? RefreshType { get; set; }

    public virtual MonitoredSqlserver Sqlserver { get; set; } = null!;
}
