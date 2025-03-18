﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class WaitStatisticsDetail
{
    public long WaitStatisticsId { get; set; }

    public int WaitTypeId { get; set; }

    public long? WaitingTasks { get; set; }

    public long? WaitTimeInMilliseconds { get; set; }

    public long? MaxWaitTimeInMilliseconds { get; set; }

    public long? ResourceWaitTimeInMilliseconds { get; set; }

    public virtual WaitStatistic WaitStatistics { get; set; } = null!;

    public virtual WaitType WaitType { get; set; } = null!;
}
