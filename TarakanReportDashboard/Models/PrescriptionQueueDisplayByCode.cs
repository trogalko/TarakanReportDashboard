﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class PrescriptionQueueDisplayByCode
{
    public string? Ip { get; set; }

    public string? ServiceUnitId { get; set; }

    public string? Code { get; set; }

    public int? CurrentPage { get; set; }
}
