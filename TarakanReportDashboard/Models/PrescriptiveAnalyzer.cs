﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class PrescriptiveAnalyzer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int AnalyzerCategoryId { get; set; }

    public virtual PrescriptiveAnalyzerCategory AnalyzerCategory { get; set; } = null!;

    public virtual ICollection<PrescriptiveAnalysisDetail> PrescriptiveAnalysisDetails { get; set; } = new List<PrescriptiveAnalysisDetail>();
}
