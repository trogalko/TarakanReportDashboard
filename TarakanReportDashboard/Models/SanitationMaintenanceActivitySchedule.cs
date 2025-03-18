﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class SanitationMaintenanceActivitySchedule
{
    public string SrworkTradeItem { get; set; } = null!;

    public string ServiceUnitId { get; set; } = null!;

    public DateTime ScheduleDate { get; set; }

    public string PeriodYear { get; set; } = null!;

    public DateTime PeriodDate { get; set; }

    public bool IsProcessed { get; set; }

    public bool IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
