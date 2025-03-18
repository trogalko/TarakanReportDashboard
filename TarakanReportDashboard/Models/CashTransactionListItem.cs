﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class CashTransactionListItem
{
    public int ListItemId { get; set; }

    public string ListId { get; set; } = null!;

    public int ChartOfAccountId { get; set; }

    public int SubledgerId { get; set; }

    public decimal Amount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
