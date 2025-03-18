﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class AnalysisConfigBlockedDatabase
{
    public int AnalysisConfigurationId { get; set; }

    public int DatabaseId { get; set; }

    public virtual AnalysisConfiguration AnalysisConfiguration { get; set; } = null!;

    public virtual SqlserverDatabaseName Database { get; set; } = null!;
}
