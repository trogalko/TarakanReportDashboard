﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class LaunderedProcess
{
    public string ProcessNo { get; set; } = null!;

    public DateTime ProcessDate { get; set; }

    public string ProcessTime { get; set; } = null!;

    public string? SrlaundryProcessType { get; set; }

    public string? SrlaundryProgram { get; set; }

    public string? SrlaundryType { get; set; }

    public string? MachineId { get; set; }

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
