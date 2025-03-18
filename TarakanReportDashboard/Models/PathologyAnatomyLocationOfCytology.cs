﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class PathologyAnatomyLocationOfCytology
{
    public string LocationId { get; set; } = null!;

    public string? LocationName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
