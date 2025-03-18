﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class PositionGoal
{
    public int PositionGoalId { get; set; }

    public int PositionId { get; set; }

    public string GoalName { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
