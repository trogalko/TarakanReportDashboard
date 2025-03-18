﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class PatientMembershipItemRedemptionDetail
{
    public string TransactionNo { get; set; } = null!;

    public long MembershipDetailId { get; set; }

    public decimal ClaimedPoint { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
