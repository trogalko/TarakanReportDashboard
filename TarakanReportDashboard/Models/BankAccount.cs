﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class BankAccount
{
    public string BankId { get; set; } = null!;

    public string BankAccountNo { get; set; } = null!;

    public string? Srcurrency { get; set; }

    public string? Notes { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
