﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class PatientFluidBalanceSchemaInfu
{
    public string RegistrationNo { get; set; } = null!;

    public int SequenceNo { get; set; }

    public int SchemaInfusNo { get; set; }

    public string SchemaInfusName { get; set; } = null!;

    public int QtyVolume { get; set; }

    public int QtyPerHour { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
