﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class KioskQueueCaller
{
    public string KioskQueueId { get; set; } = null!;

    public string? KiosKroomId { get; set; }

    public string? RegistrationNo { get; set; }

    public DateTime? KioskQueueDate { get; set; }

    public string? SrkioskQueueStatus { get; set; }

    public DateTime CreateDateTime { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? ExternalQueNo { get; set; }
}
