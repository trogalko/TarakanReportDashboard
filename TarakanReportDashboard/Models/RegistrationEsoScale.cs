﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class RegistrationEsoScale
{
    public string RegistrationNo { get; set; } = null!;

    public int EsoNo { get; set; }

    public string SresoScale { get; set; } = null!;

    public string? ScaleStatus { get; set; }

    public int? ScaleValue { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
