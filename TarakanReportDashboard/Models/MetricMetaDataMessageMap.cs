using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class MetricMetaDataMessageMap
{
    public int Metric { get; set; }

    public int Value { get; set; }

    public int MessageId { get; set; }
}
