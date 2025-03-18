﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class PastMedicalHistory
{
    public string PatientId { get; set; } = null!;

    public string SrmedicalDisease { get; set; } = null!;

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
