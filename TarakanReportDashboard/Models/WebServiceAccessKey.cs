using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class WebServiceAccessKey
{
    public string ClientCode { get; set; } = null!;

    public string? ClientName { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? AccessKey { get; set; }

    public string? RequestUrl { get; set; }

    public string? ResponseUrl { get; set; }
}
