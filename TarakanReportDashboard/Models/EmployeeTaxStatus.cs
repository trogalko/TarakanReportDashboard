﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class EmployeeTaxStatus
{
    public int PersonId { get; set; }

    public int Sptyear { get; set; }

    public string SrtaxStatus { get; set; } = null!;

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
