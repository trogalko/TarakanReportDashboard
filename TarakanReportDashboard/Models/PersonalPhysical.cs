﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class PersonalPhysical
{
    public int PersonalPhysicalId { get; set; }

    public int PersonId { get; set; }

    public string SrphysicalCharacteristic { get; set; } = null!;

    public string PhysicalValue { get; set; } = null!;

    public string? SrmeasurementCode { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
