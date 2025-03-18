﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class SupplierItem
{
    public string SupplierId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public decimal PurchaseDiscount1 { get; set; }

    public decimal PurchaseDiscount2 { get; set; }

    public string SrpurchaseUnit { get; set; } = null!;

    public decimal PriceInPurchaseUnit { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? DrugDistributionLicenseNo { get; set; }

    public decimal? ConversionFactor { get; set; }
}
