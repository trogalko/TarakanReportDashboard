﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class ApplicantFamily
{
    public int ApplicantFamilyId { get; set; }

    public int ApplicantId { get; set; }

    public string SrfamilyRelation { get; set; } = null!;

    public string FamilyName { get; set; } = null!;

    public DateTime DateBirth { get; set; }

    public string? SreducationLevel { get; set; }

    public string? Address { get; set; }

    public string? SrmaritalStatus { get; set; }

    public string? SrgenderType { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
