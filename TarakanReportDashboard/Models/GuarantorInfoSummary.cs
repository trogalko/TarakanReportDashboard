﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class GuarantorInfoSummary
{
    public string GuarantorId { get; set; } = null!;

    public int? NoteCount { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
