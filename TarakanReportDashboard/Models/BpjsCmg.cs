﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class BpjsCmg
{
    public string NoSep { get; set; } = null!;

    public string KodeCmg { get; set; } = null!;

    public decimal? TariffCmg { get; set; }

    public string? DeskripsiCmg { get; set; }

    public string? TipeCmg { get; set; }

    public bool? IsOptionCmg { get; set; }
}
