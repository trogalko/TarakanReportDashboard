﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class SalaryTemplateItem
{
    public string SalaryTemplateId { get; set; } = null!;

    public int SalaryComponentId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
