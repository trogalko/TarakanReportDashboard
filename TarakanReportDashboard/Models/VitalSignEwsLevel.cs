﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class VitalSignEwsLevel
{
    public string VitalSignId { get; set; } = null!;

    public int StartAgeInDay { get; set; }

    public decimal StartValue { get; set; }

    public int EwsLevel { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
