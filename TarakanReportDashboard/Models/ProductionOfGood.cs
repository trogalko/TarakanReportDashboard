﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class ProductionOfGood
{
    public string ProductionNo { get; set; } = null!;

    public DateTime ProductionDate { get; set; }

    public string ServiceUnitId { get; set; } = null!;

    public string LocationId { get; set; } = null!;

    public string FormulaId { get; set; } = null!;

    public decimal Qty { get; set; }

    public decimal Price { get; set; }

    public decimal CostAmount { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public string? Notes { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? ToServiceUnitId { get; set; }
}
