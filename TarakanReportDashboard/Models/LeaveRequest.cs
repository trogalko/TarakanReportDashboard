﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class LeaveRequest
{
    public int LeaveRequestId { get; set; }

    public int PersonId { get; set; }

    public DateTime RequestDate { get; set; }

    public int LeaveTypeId { get; set; }

    public decimal LeaveBalance { get; set; }

    public DateTime LeaveDateFrom { get; set; }

    public string LeaveTimeFrom { get; set; } = null!;

    public DateTime LeaveDateTo { get; set; }

    public string LeaveTimeTo { get; set; } = null!;

    public decimal RequestDays { get; set; }

    public DateTime? WorkingDate { get; set; }

    public string? Reason { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
