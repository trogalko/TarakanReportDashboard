using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class ServiceUnitImageTemplate
{
    public string ServiceUnitId { get; set; } = null!;

    public string ImageTemplateId { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
