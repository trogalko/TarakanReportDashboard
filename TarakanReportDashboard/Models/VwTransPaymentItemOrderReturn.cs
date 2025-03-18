﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class VwTransPaymentItemOrderReturn
{
    public string PaymentNo { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public decimal Qty { get; set; }

    public decimal Price { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public bool IsPaymentProceed { get; set; }

    public bool IsPaymentReturned { get; set; }

    public string JournalIncomePaymentNo { get; set; } = null!;

    public bool IsVoid { get; set; }

    public string TransactionCode { get; set; } = null!;
}
