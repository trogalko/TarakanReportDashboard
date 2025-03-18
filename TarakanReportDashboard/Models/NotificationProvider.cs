using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class NotificationProvider
{
    public Guid ProviderId { get; set; }

    public string SerializedType { get; set; } = null!;

    public string SerializedObject { get; set; } = null!;
}
