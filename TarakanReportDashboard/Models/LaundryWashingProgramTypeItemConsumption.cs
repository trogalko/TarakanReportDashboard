﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class LaundryWashingProgramTypeItemConsumption
{
    public string SrlaundryProcessType { get; set; } = null!;

    public string SrlaundryProgram { get; set; } = null!;

    public string SrlaundryType { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public decimal Qty { get; set; }

    public string SritemUnit { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
