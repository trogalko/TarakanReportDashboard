﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class AtePatientsControl
{
    public string OrderNo { get; set; } = null!;

    public string SrmealSet { get; set; } = null!;

    public DateTime? ControlDate { get; set; }

    public string? Carbohydrate { get; set; }

    public string? VegetableSideDish { get; set; }

    public string? AnimalSideDish { get; set; }

    public string? Vegetable { get; set; }

    public string? Fruit { get; set; }

    public string? Beverage { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? SreatingPatientStatusReason { get; set; }
}
