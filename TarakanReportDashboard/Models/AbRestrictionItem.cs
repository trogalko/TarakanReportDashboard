using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class AbRestrictionItem
{
    public string AbRestrictionId { get; set; } = null!;

    public int AbLevel { get; set; }

    public string ZatActiveId { get; set; } = null!;

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
