﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class AppParameter
{
    public string ParameterId { get; set; } = null!;

    public string? ParameterName { get; set; }

    public string? ParameterValue { get; set; }

    public string? ParameterType { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public bool IsUsedBySystem { get; set; }

    public string? Message { get; set; }
}
