﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class PositionPsychological
{
    public int PositionPsychologicalId { get; set; }

    public int PositionId { get; set; }

    public string Srpsychological { get; set; } = null!;

    public string SroperandType { get; set; } = null!;

    public string PsychologicalValue { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
