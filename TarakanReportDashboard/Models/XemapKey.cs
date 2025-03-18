using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class XemapKey
{
    public string WaitType { get; set; } = null!;

    public int Sqlversion { get; set; }

    public int MapKey { get; set; }
}
