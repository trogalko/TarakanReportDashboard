﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class SubLedgerGroup
{
    public int SubLedgerGroupId { get; set; }

    public string GroupCode { get; set; } = null!;

    public string GroupName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string LastUpdateByUserId { get; set; } = null!;

    public int? TempId { get; set; }

    public virtual ICollection<SubLedger> SubLedgers { get; set; } = new List<SubLedger>();
}
