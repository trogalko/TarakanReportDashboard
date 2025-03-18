using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class GuarantorItemTypeRule
{
    public string GuarantorId { get; set; } = null!;

    public string SritemType { get; set; } = null!;

    public bool IsToGuarantor { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
