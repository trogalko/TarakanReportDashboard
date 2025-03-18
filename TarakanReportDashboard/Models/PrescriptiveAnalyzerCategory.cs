using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class PrescriptiveAnalyzerCategory
{
    public int Id { get; set; }

    public string Category { get; set; } = null!;

    public virtual ICollection<PrescriptiveAnalyzer> PrescriptiveAnalyzers { get; set; } = new List<PrescriptiveAnalyzer>();
}
