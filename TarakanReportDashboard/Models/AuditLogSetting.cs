﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class AuditLogSetting
{
    public string TableName { get; set; } = null!;

    public string TableDescription { get; set; } = null!;

    public bool IsAuditLog { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public bool? IsConsolidationBranchToHo { get; set; }

    public bool? IsConsolidationHotoBranch { get; set; }
}
