﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class SatuSehatKunjungan
{
    public string RegistrationNo { get; set; } = null!;

    public Guid? EncounterId { get; set; }

    public string? KunjunganPostData { get; set; }

    public bool? IsClosed { get; set; }

    public string? ErrorResponse { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
