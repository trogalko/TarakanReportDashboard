﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class HasilPasien
{
    public string? OrderLabNo { get; set; }

    public DateTime? OrderLabTglOrder { get; set; }

    public string? OrderLabNoMr { get; set; }

    public string? OrderLabNama { get; set; }

    public int? CheckupResultGroupCode { get; set; }

    public string? CheckupResultGroupName { get; set; }

    public string? CheckupResultTestCode { get; set; }

    public string? CheckupResultTestName { get; set; }

    public string? CheckupResultFractionCode { get; set; }

    public string? CheckupResultFractionName { get; set; }

    public string? WithinRange { get; set; }

    public string? OutRange { get; set; }

    public string? Satuan { get; set; }

    public string? StandarValue { get; set; }

    public string? OrderLabCritical { get; set; }

    public int? Seq { get; set; }
}
