using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class VwGetLatestItemPorPrice
{
    public string ItemId { get; set; } = null!;

    public decimal Price { get; set; }

    public DateTime TransactionDate { get; set; }
}
