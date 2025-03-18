﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class TransChargesItemComp
{
    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string TariffComponentId { get; set; } = null!;

    public decimal Price { get; set; }

    public decimal DiscountAmount { get; set; }

    public string? ParamedicId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public bool? IsPackage { get; set; }

    public decimal AutoProcessCalculation { get; set; }

    public decimal? CitoAmount { get; set; }

    public string? FeeSettledNo { get; set; }

    public decimal? FeeCalculated { get; set; }

    public decimal? FeeDiscountPercentage { get; set; }

    public decimal? FeeDiscount { get; set; }

    public decimal? PriceAdjusted { get; set; }
}
