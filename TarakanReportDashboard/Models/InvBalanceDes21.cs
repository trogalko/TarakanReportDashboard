﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class InvBalanceDes21
{
    public string? LocationId { get; set; }

    public string? LocationName { get; set; }

    public string? ItemId { get; set; }

    public string? ItemName { get; set; }

    public decimal? AwJumlah { get; set; }

    public decimal? AwNilai { get; set; }

    public decimal? QmJumlah { get; set; }

    public decimal? QmNilai { get; set; }

    public decimal? QkJumlah { get; set; }

    public decimal? QkNilai { get; set; }

    public decimal? AkJumlah { get; set; }

    public decimal? AkNilai { get; set; }

    public decimal? Hpr { get; set; }
}
