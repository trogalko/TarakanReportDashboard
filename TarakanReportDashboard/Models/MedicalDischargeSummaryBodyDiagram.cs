﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class MedicalDischargeSummaryBodyDiagram
{
    public string RegistrationNo { get; set; } = null!;

    public string BodyId { get; set; } = null!;

    public byte[]? BodyImage { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? Notes { get; set; }
}
