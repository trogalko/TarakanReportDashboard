using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class ClosingThrTransaction
{
    public int PayrollPeriodId { get; set; }

    public bool? IsClosed { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
