﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class InvoiceSupplierItemConsignment
{
    public string InvoiceNo { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public decimal Qty { get; set; }

    public decimal Price { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
