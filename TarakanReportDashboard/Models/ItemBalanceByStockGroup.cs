﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class ItemBalanceByStockGroup
{
    public string SrstockGroup { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public decimal? Minimum { get; set; }

    public decimal? Maximum { get; set; }

    public decimal? Balance { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
