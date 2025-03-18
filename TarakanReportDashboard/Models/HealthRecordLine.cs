﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class HealthRecordLine
{
    public string PatientId { get; set; } = null!;

    public string QuestionFormId { get; set; } = null!;

    public string QuestionGroupId { get; set; } = null!;

    public string QuestionId { get; set; } = null!;

    public string? QuestionAnswerPrefix { get; set; }

    public string? QuestionAnswerSuffix { get; set; }

    public string? QuestionAnswerSelectionLineId { get; set; }

    public string? QuestionAnswerText { get; set; }

    public decimal? QuestionAnswerNum { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
