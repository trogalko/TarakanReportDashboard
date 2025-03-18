﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class AuditableAction
{
    public int ActionId { get; set; }

    public string Name { get; set; } = null!;

    public short? SecurityRequired { get; set; }

    public string? HeaderTemplate { get; set; }
}
