﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class SanitationWasteItemBalance
{
    public string SrwasteType { get; set; } = null!;

    public decimal? Balance { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
