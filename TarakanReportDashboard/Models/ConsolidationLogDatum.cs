﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class ConsolidationLogDatum
{
    public int ConsolidationLogId { get; set; }

    public string ColumnName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public bool? IsInPrimaryKey { get; set; }
}
