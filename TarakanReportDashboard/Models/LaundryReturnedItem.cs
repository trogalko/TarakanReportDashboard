﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class LaundryReturnedItem
{
    public string ReturnNo { get; set; } = null!;

    public string ReturnSeqNo { get; set; } = null!;

    public string ProcessNo { get; set; } = null!;

    public string ProcessSeqNo { get; set; } = null!;

    public string? ItemId { get; set; }

    public decimal Qty { get; set; }

    public bool? IsInfectious { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
