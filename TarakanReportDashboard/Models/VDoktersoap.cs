﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class VDoktersoap
{
    public string ParamedicName { get; set; } = null!;

    public int? TotalReseps { get; set; }

    public int? TotalSoaps { get; set; }

    public string? SrregistrationType { get; set; }
}
