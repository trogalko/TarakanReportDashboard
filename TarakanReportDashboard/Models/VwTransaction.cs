﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class VwTransaction
{
    public string TransactionNo { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string? ServiceUnitId { get; set; }

    public string ReferenceNo { get; set; } = null!;

    public bool IsCorrection { get; set; }

    public DateTime FilterDate { get; set; }

    public string OrderTransNo { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public int? IsPackage { get; set; }

    public string PackageReferenceNo { get; set; } = null!;

    public bool? IsPrescription { get; set; }

    public string ClassId { get; set; } = null!;
}
