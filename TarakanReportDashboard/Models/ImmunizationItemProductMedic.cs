using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class ImmunizationItemProductMedic
{
    public string ImmunizationId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
