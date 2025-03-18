﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class ApplicantContact
{
    public int ApplicantContactId { get; set; }

    public int ApplicantId { get; set; }

    public string SrcontactType { get; set; } = null!;

    public string ContactValue { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
