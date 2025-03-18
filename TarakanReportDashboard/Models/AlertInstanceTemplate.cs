using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class AlertInstanceTemplate
{
    public int Id { get; set; }

    public int? SqlserverId { get; set; }

    public int? TemplateId { get; set; }
}
