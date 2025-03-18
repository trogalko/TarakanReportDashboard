using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class ItemTransactionInitialBalance
{
    public string TransactionNo { get; set; } = null!;

    public bool? IsInitialBalance { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
