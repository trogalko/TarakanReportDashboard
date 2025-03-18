﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class ContributoryFactorsClassificationFramework
{
    public string FactorId { get; set; } = null!;

    public string? FactorName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
