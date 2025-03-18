using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class VwPatientsPaidOff
{
    public string RegistrationNo { get; set; } = null!;

    public bool? IsPaidOff { get; set; }
}
