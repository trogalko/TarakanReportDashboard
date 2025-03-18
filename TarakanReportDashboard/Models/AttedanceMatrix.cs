using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class AttedanceMatrix
{
    public int AttedanceMatrixId { get; set; }

    public string? AttedanceMatrixName { get; set; }

    public string? AttedanceMatrixFieldt { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
