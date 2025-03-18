using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class EmployeeIncentiveProcessItemDetail
{
    public int EmployeeIncentiveProcessId { get; set; }

    public string SrincentiveServiceUnitGroup { get; set; } = null!;

    public int PersonId { get; set; }

    public decimal? Points { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
