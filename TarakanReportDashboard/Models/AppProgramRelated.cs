﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class AppProgramRelated
{
    public string ProgramId { get; set; } = null!;

    public string RelatedProgramId { get; set; } = null!;

    public string ReferenceId { get; set; } = null!;
}
