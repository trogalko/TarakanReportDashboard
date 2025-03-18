using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class VwItemProductSalesAvailable
{
    public string ItemId { get; set; } = null!;

    public bool? IsSalesAvailable { get; set; }
}
