﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class EmployeeClinicalPrivilege
{
    public int EmployeeClinicalPrivilegeId { get; set; }

    public int PersonId { get; set; }

    public string SrprofessionGroup { get; set; } = null!;

    public string SrclinicalWorkArea { get; set; } = null!;

    public string SrclinicalAuthorityLevel { get; set; } = null!;

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public string? DecreeNo { get; set; }

    public string? TransactionNo { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
