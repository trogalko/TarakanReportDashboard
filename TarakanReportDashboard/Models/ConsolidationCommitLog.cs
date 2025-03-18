﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class ConsolidationCommitLog
{
    public long CommitId { get; set; }

    public DateTime CommitDateTime { get; set; }

    public string? HealthcareId { get; set; }

    public bool IsManualLog { get; set; }

    public string CommitSummary { get; set; } = null!;

    public string CommitData { get; set; } = null!;

    public long? StartConsolidationLogId { get; set; }

    public long? EndConsolidationLogId { get; set; }

    public bool? IsError { get; set; }

    public string? ErrorMessage { get; set; }

    public bool? IsSendFailed { get; set; }
}
