﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class Indication
{
    public string IndicationId { get; set; } = null!;

    public string IndicationName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public string? InsertByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
