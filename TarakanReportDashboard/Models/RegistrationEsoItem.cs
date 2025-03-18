﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class RegistrationEsoItem
{
    public string RegistrationNo { get; set; } = null!;

    public int EsoNo { get; set; }

    public long MedicationReceiveNo { get; set; }

    public bool? IsSuspect { get; set; }

    public DateTime? StartConsumeDateTime { get; set; }

    public DateTime? EndConsumeDateTime { get; set; }

    public string? ConsumeIndication { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
