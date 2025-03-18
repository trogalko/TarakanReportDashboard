using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class VwItemServicesRlReport
{
    public string ItemId { get; set; } = null!;

    public int? RlMasterReportItemId { get; set; }
}
