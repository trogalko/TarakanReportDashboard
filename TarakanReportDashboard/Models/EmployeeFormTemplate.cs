﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class EmployeeFormTemplate
{
    public int TemplateId { get; set; }

    public string TemplateName { get; set; } = null!;

    public string Result { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
