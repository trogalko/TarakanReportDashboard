﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class ProductionFormulaItem
{
    public string FormulaId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public decimal Qty { get; set; }

    public string SritemUnit { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public bool? IsConsumables { get; set; }
}
