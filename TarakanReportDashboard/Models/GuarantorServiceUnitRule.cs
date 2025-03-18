﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class GuarantorServiceUnitRule
{
    public string GuarantorId { get; set; } = null!;

    public string ServiceUnitId { get; set; } = null!;

    public bool? IsCovered { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
