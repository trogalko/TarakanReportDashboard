﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class AveragePriceHistory
{
    public string TransactionNo { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string ItemUnit { get; set; } = null!;

    public DateTime ChangedDate { get; set; }

    public string TransactionCode { get; set; } = null!;

    public decimal OldAveragePrice { get; set; }

    public decimal NewAveragePrice { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public decimal? OldPriceInBaseUnit { get; set; }

    public decimal? OldPriceInPurchaseUnit { get; set; }

    public decimal? OldPurchaseDiscount1 { get; set; }

    public decimal? OldPurchaseDiscount2 { get; set; }

    public decimal? NewPriceInBaseUnit { get; set; }

    public decimal? NewPriceInPurchaseUnit { get; set; }

    public decimal? NewPurchaseDiscount1 { get; set; }

    public decimal? NewPurchaseDiscount2 { get; set; }
}
