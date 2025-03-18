using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class QuestionAnswerSelection
{
    public string QuestionAnswerSelectionId { get; set; } = null!;

    public string? QuestionAnswerSelectionText { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
