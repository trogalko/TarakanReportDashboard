﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class PaymentType
{
    public string SrpaymentTypeId { get; set; } = null!;

    public string PaymentTypeName { get; set; } = null!;

    public int? ChartOfAccountId { get; set; }

    public int? SubledgerId { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public bool IsCashierFrontOffice { get; set; }

    public bool? IsArPayment { get; set; }

    public bool? IsApPayment { get; set; }

    public bool? IsFeePayment { get; set; }

    public bool? IsAssetAuctionPayment { get; set; }
}
