﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class PersonalLicence
{
    public int PersonalLicenceId { get; set; }

    public int PersonId { get; set; }

    public string SrlicenceType { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public string Note { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime? VerificationDate { get; set; }

    public string? VerificationLetterNo { get; set; }

    public bool? IsLifetime { get; set; }
}
