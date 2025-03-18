﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class BloodReceived
{
    public string TransactionNo { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string SrbloodSource { get; set; } = null!;

    public string SrbloodSourceFrom { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
