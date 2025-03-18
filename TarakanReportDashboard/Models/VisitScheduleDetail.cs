﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class VisitScheduleDetail
{
    public string ScheduleVisitId { get; set; } = null!;

    public string ScheduleId { get; set; } = null!;

    public DateOnly? VisitDateTime { get; set; }

    public bool? VisitStatus { get; set; }

    public string? RegistrationNo { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? UpdatedByUserId { get; set; }

    public DateTime? UpdatedDateTime { get; set; }
}
