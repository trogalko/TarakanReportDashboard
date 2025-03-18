﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class RiskManagement
{
    public string RiskManagementNo { get; set; } = null!;

    public short PeriodYear { get; set; }

    public string ServiceUnitId { get; set; } = null!;

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
