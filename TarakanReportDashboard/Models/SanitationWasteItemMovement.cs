﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class SanitationWasteItemMovement
{
    public long MovementId { get; set; }

    public DateTime MovementDate { get; set; }

    public string TransactionCode { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public string SrwasteType { get; set; } = null!;

    public decimal? InitialQty { get; set; }

    public decimal? QtyIn { get; set; }

    public decimal? QtyOut { get; set; }

    public decimal? Balance { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
