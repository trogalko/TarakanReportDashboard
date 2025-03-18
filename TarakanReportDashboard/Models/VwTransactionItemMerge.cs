using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class VwTransactionItemMerge
{
    public string Label { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ItemId { get; set; } = null!;
}
