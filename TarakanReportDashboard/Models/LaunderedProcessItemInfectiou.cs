﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class LaunderedProcessItemInfectiou
{
    public string ProcessNo { get; set; } = null!;

    public string ProcessSeqNo { get; set; } = null!;

    public string ReceivedNo { get; set; } = null!;

    public string ReceivedSeqNo { get; set; } = null!;

    public decimal Qty { get; set; }

    public string SritemUnit { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
