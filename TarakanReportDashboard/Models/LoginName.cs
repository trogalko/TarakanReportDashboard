using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class LoginName
{
    public int LoginNameId { get; set; }

    public string? LoginName1 { get; set; }

    public virtual ICollection<DeadlockProcess> DeadlockProcesses { get; set; } = new List<DeadlockProcess>();
}
