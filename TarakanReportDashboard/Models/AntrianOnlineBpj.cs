﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class AntrianOnlineBpj
{
    public string TanggalAntrian { get; set; } = null!;

    public int? AntrianSelesai { get; set; }

    public int? AntrianBatal { get; set; }

    public int? AntrianBelumSelesai { get; set; }

    public int? TotalSep { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
