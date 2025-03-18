using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class LaundryWashingMachineProgram
{
    public string MachineId { get; set; } = null!;

    public string SrlaundryProgram { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
