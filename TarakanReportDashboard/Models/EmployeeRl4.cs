﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class EmployeeRl4
{
    public int EmployeeRl4id { get; set; }

    public int PersonId { get; set; }

    public int CompanyEducationProfileId { get; set; }

    public int CompanyFieldOfWorkProfileId { get; set; }

    public string Srrl4status { get; set; } = null!;

    public string Srrl4type { get; set; } = null!;

    public string SrmedisType { get; set; } = null!;

    public string SreducationLevel { get; set; } = null!;

    public int Rl4educationId { get; set; }

    public bool IsActive { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public string? Srrl4professionType { get; set; }

    public string? Srrl4educationLevel { get; set; }

    public string? Srrl4educationMajor { get; set; }
}
