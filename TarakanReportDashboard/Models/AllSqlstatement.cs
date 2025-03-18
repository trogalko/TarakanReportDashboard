using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class AllSqlstatement
{
    public int SqlstatementId { get; set; }

    public string? SqlstatementHash { get; set; }

    public string? Sqlstatement { get; set; }
}
