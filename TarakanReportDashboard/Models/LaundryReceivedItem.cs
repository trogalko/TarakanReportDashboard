﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class LaundryReceivedItem
{
    public string ReceivedNo { get; set; } = null!;

    public string ReceivedSeqNo { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string SritemUnit { get; set; } = null!;

    public decimal Qty { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
