﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class SatuSehatMappingId
{
    public string MappingType { get; set; } = null!;

    public string AvicennaId { get; set; } = null!;

    public string? SatuSehatId { get; set; }
}
