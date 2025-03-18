﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class AlwaysOnReplica
{
    public long ReplicaTopologyId { get; set; }

    public Guid ReplicaId { get; set; }

    public Guid GroupId { get; set; }

    public int SqlserverId { get; set; }

    public string ServerSourceName { get; set; } = null!;

    public string ReplicaName { get; set; } = null!;

    public int ReplicaRole { get; set; }

    public int FailoverMode { get; set; }

    public int AvailabilityMode { get; set; }

    public byte PrimaryConnectionMode { get; set; }

    public byte SecondaryConnectionMode { get; set; }

    public bool Active { get; set; }

    public bool Delete { get; set; }

    public virtual MonitoredSqlserver Sqlserver { get; set; } = null!;
}
