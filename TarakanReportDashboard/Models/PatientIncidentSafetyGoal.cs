﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class PatientIncidentSafetyGoal
{
    public string PatientIncidentNo { get; set; } = null!;

    public string SrsafetyGoals { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
