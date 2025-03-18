﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class EmployeeIncentiveProcessItem
{
    public int EmployeeIncentiveProcessId { get; set; }

    public string SrincentiveServiceUnitGroup { get; set; } = null!;

    public decimal? Nominal { get; set; }

    public decimal? TotalPoint { get; set; }

    public decimal? NominalPerPoint { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
