using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class AppUserSetting
{
    public string UserId { get; set; } = null!;

    public string? QueueingCounterSetting { get; set; }
}
