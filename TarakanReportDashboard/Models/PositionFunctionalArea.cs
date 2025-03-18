using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class PositionFunctionalArea
{
    public int PositionFunctionalAreaId { get; set; }

    public int PositionId { get; set; }

    public string SrpositionFunctionalArea { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
