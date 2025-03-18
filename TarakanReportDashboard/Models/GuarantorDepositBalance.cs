﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class GuarantorDepositBalance
{
    public string GuarantorId { get; set; } = null!;

    public decimal BalanceAmount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
