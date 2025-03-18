﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class PrescriptiveAnalysisType
{
    public int AnalysisTypeId { get; set; }

    public string AnalysisType { get; set; } = null!;

    public virtual ICollection<PrescriptiveAnalysis> PrescriptiveAnalyses { get; set; } = new List<PrescriptiveAnalysis>();
}
