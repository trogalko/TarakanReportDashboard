using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class InitialLeaveType
{
    public int InitialLeaveTypeId { get; set; }

    public string LeaveTypeName { get; set; } = null!;
}
