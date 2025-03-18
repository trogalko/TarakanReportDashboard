﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class EmployeeOvertimeItem
{
    public string TransactionNo { get; set; } = null!;

    public int PersonId { get; set; }

    public int SalaryComponentId { get; set; }

    public decimal Amount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public int? WorkingHourId { get; set; }

    public string? Notes { get; set; }
}
