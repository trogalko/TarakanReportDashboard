﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class BakUserLogGriskaliaT
{
    public long UserLogId { get; set; }

    public string? ApplicationId { get; set; }

    public string SessionId { get; set; } = null!;

    public string? UserId { get; set; }

    public DateTime? LoginDateTime { get; set; }

    public string? ClientIp { get; set; }

    public string? BrowserInfo { get; set; }

    public DateTime? LogoutDateTime { get; set; }
}
