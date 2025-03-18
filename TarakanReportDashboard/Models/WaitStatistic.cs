using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class WaitStatistic
{
    public long WaitStatisticsId { get; set; }

    public int SqlserverId { get; set; }

    public DateTime UtccollectionDateTime { get; set; }

    public double? TimeDeltaInSeconds { get; set; }

    public virtual MonitoredSqlserver Sqlserver { get; set; } = null!;

    public virtual ICollection<WaitStatisticsDetail> WaitStatisticsDetails { get; set; } = new List<WaitStatisticsDetail>();
}
