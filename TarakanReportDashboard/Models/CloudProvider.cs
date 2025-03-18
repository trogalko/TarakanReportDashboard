using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class CloudProvider
{
    public int CloudProviderId { get; set; }

    public string CloudProviderName { get; set; } = null!;
}
