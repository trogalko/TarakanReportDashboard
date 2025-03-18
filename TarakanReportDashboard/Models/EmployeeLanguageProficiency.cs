﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class EmployeeLanguageProficiency
{
    public int EmployeeLanguageProficiencyId { get; set; }

    public int PersonId { get; set; }

    public DateTime EvaluationDate { get; set; }

    public string Srlanguage { get; set; } = null!;

    public string Srconversation { get; set; } = null!;

    public string Srtranslation { get; set; } = null!;

    public string? Notes { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
