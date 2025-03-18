﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class QuestionGroup
{
    public string QuestionGroupId { get; set; } = null!;

    public string QuestionGroupName { get; set; } = null!;

    public string? QuestionGroupNameEn { get; set; }

    public int? OrderNo { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? SoapType { get; set; }
}
