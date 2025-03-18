using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class VwTransChargesItemPaymentType
{
    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string PaymentMethodName { get; set; } = null!;
}
