using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class ProductionFormulaOtherItem
{
    public string FormulaId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public decimal Qty { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
