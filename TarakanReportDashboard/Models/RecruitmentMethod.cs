﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class RecruitmentMethod
{
    public int RecruitmentMethodId { get; set; }

    public int PersonnelRequisitionId { get; set; }

    public string SrrecruitmentMethod { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
