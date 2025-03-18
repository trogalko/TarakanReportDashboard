using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class CasemixCoveredGuarantor
{
    public string GuarantorId { get; set; } = null!;

    public int CasemixCoveredId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
