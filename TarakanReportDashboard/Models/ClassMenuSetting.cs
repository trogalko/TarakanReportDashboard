﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class ClassMenuSetting
{
    public string ClassId { get; set; } = null!;

    public bool IsOptional { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
