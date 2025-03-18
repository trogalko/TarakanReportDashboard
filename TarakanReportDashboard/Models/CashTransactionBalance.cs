﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class CashTransactionBalance
{
    public int TxnBalanceId { get; set; }

    public int TransactionId { get; set; }

    public int ChartOfAccountId { get; set; }

    public string NormalBalance { get; set; } = null!;

    public decimal Amount { get; set; }

    public decimal InitialBalance { get; set; }

    public decimal DebitAmount { get; set; }

    public decimal CreditAmount { get; set; }

    public decimal FinalBalance { get; set; }

    public int? ReconcileId { get; set; }

    public virtual CashTransaction Transaction { get; set; } = null!;
}
