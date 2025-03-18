﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class MonitoredServerSqlsafeInstance
{
    public int SqlserverId { get; set; }

    public int RepositoryId { get; set; }

    public int RelatedInstanceId { get; set; }

    public int LastBackupActionId { get; set; }

    public int LastDefragActionId { get; set; }

    public virtual SqlsafeConnection Repository { get; set; } = null!;

    public virtual MonitoredSqlserver Sqlserver { get; set; } = null!;
}
