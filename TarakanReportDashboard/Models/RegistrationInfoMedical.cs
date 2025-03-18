﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class RegistrationInfoMedical
{
    public long Id { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string SrmedicalNotesInputType { get; set; } = null!;

    public DateTime DateTimeInfo { get; set; }

    public string Info1 { get; set; } = null!;

    public string Info2 { get; set; } = null!;

    public string Info3 { get; set; } = null!;

    public string Info4 { get; set; } = null!;

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
