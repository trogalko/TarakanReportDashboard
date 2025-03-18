﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class UserSessionDatum
{
    public string UserId { get; set; } = null!;

    public DateTime SessionLogin { get; set; }

    public string ClientIp { get; set; } = null!;
}
