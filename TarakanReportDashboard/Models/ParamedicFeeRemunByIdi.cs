﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class ParamedicFeeRemunByIdi
{
    public int RemunId { get; set; }

    public string RemunNo { get; set; } = null!;

    public decimal? FundAllocProcedure { get; set; }

    public decimal? FundAllocPosition { get; set; }

    public decimal? FundAllocInsetif { get; set; }

    public decimal? KursPosition { get; set; }

    public decimal? KursInsentif { get; set; }

    public decimal? AdjustmentFactor { get; set; }

    public string? Notes { get; set; }

    public bool IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserId { get; set; }

    public bool IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserId { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? CreateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }
}
