﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class CompanyFieldOfWorkProfile
{
    public int CompanyFieldOfWorkProfileId { get; set; }

    public int CompanyLaborProfileId { get; set; }

    public string CompanyFieldOfWorkProfileCode { get; set; } = null!;

    public string? CompanyFieldOfWorkProfileName { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
