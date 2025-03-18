﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class NutritionCareTerminologyTemplate
{
    public int TemplateId { get; set; }

    public string TemplateName { get; set; } = null!;

    public string TemplateText { get; set; } = null!;

    public bool IsActive { get; set; }

    public string CreateByUserId { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }
}
