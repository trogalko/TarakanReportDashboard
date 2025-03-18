﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class PersonalEducationHistory
{
    public int PersonalEducationHistoryId { get; set; }

    public int PersonId { get; set; }

    public string SreducationLevel { get; set; } = null!;

    public string? InstitutionName { get; set; }

    public string? Location { get; set; }

    public string? StartYear { get; set; }

    public string? EndYear { get; set; }

    public decimal? Gpa { get; set; }

    public string? Achievement { get; set; }

    public string? Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public string? Majors { get; set; }

    public DateTime? GraduateDate { get; set; }

    public string? DiplomaNo { get; set; }

    public string? DiplomaVerificationNo { get; set; }

    public DateTime? EducationalAdjustmentDate { get; set; }
}
