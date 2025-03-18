﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class PrescriptiveOptimiztionExecutionStatus
{
    public int Id { get; set; }

    public string Status { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<PrescriptiveAnalysisRecommendation> PrescriptiveAnalysisRecommendations { get; set; } = new List<PrescriptiveAnalysisRecommendation>();
}
