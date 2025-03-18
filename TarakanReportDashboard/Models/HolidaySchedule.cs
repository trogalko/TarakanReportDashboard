﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class HolidaySchedule
{
    public string PeriodYear { get; set; } = null!;

    public DateTime HolidayDate { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
