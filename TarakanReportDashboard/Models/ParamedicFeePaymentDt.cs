using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class ParamedicFeePaymentDt
{
    public string PaymentNo { get; set; } = null!;

    public string VerificationNo { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
