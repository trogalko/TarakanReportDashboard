﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class VwHasilPasienVanslab
{
    public string? TransactionNo { get; set; }

    public int? NoUrut { get; set; }

    public string? KodePemeriksaan { get; set; }

    public string? NamaPemeriksaan { get; set; }

    public string? Hasil { get; set; }

    public string? StandardValue { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string? KodeTest { get; set; }

    public string? Teks { get; set; }

    public string? Unit { get; set; }

    public string? Normal { get; set; }

    public string Flag { get; set; } = null!;

    public string? KodeSir { get; set; }
}
