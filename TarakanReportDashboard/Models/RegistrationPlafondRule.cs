﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class RegistrationPlafondRule
{
    public string RegistrationNo { get; set; } = null!;

    public decimal? PlafondAmount { get; set; }

    public bool? IsPlafondInPercent { get; set; }

    public bool? IsToGuarantor { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
