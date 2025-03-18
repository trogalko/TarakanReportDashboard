using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class SqlstatementsOverflow
{
    public int SqlstatementId { get; set; }

    public string? SqlstatementOverflow { get; set; }

    public virtual Sqlstatement Sqlstatement { get; set; } = null!;
}
