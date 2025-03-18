﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class BpjsRujukanCodeBlueUserClaim
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public string? ClaimType { get; set; }

    public string? ClaimValue { get; set; }

    public virtual BpjsRujukanCodeBlueUser1 User { get; set; } = null!;
}
