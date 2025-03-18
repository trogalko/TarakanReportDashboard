﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class ParamedicLeaveDate
{
    public string TransactionNo { get; set; } = null!;

    public DateTime LeaveDate { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
