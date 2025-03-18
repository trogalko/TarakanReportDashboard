﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class AppControl
{
    public string ControlId { get; set; } = null!;

    public string? ControlType { get; set; }

    public string? Description { get; set; }

    public string? ControlUrl { get; set; }
}
