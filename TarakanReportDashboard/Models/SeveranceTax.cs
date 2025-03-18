﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class SeveranceTax
{
    public int SeveranceTaxId { get; set; }

    public DateTime ValidFrom { get; set; }

    public bool? IsNpwp { get; set; }

    public decimal LowerLimit { get; set; }

    public decimal UpperLimit { get; set; }

    public decimal TaxRate { get; set; }

    public decimal TaxAmount { get; set; }

    public decimal AmountOfDeduction { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
