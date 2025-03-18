using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class QuestionFormInServiceUnit
{
    public string ServiceUnitId { get; set; } = null!;

    public string QuestionFormId { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
