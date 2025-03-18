using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class VwTransactionItem
{
    public int TxType { get; set; }

    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ParamedicCollectionName { get; set; } = null!;
}
