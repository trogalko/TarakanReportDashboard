﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class PatientDocumentImage
{
    public string PatientId { get; set; } = null!;

    public int SequenceNo { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string? SrimageTemplateType { get; set; }

    public string? ImageTemplateId { get; set; }

    public string Name { get; set; } = null!;

    public string? Notes { get; set; }

    public byte[]? Image { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
