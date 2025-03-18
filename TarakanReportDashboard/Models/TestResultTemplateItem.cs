using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class TestResultTemplateItem
{
    public long TestResultTemplateId { get; set; }

    public string ItemId { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
