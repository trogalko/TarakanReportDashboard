﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class Thr
{
    public int PersonId { get; set; }

    public string EmployeeName { get; set; } = null!;

    public decimal TaxAllowance { get; set; }

    public decimal TotalThr { get; set; }

    public decimal Dpp { get; set; }

    public decimal Pkp { get; set; }

    public decimal Pph21Setahun { get; set; }

    public decimal Pph21 { get; set; }

    public decimal Thr1 { get; set; }
}
