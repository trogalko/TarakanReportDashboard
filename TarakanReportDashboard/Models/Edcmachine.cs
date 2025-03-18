﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class Edcmachine
{
    public string EdcmachineId { get; set; } = null!;

    /// <summary>
    /// Lippo, BCA, BNI
    /// </summary>
    public string SrcardProvider { get; set; } = null!;

    public string EdcmachineName { get; set; } = null!;

    public bool IsActive { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public int? ChartOfAccountId { get; set; }

    public int? SubledgerId { get; set; }

    public virtual ICollection<EdcmachineTariff> EdcmachineTariffs { get; set; } = new List<EdcmachineTariff>();
}
