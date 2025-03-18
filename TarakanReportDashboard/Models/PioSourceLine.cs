﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class PioSourceLine
{
    public int PioNo { get; set; }

    public string SrpioSource { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
