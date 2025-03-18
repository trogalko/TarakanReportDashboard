﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class DietPatient
{
    public string TransactionNo { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public decimal? Height { get; set; }

    public decimal? Weight { get; set; }

    public decimal? BodyMassIndex { get; set; }

    public string? Diagnose { get; set; }

    public string? Notes { get; set; }

    public DateTime EffectiveStartDate { get; set; }

    public string EffectiveStartTime { get; set; } = null!;

    public DateTime? EffectiveEndDate { get; set; }

    public string? EffectiveEndTime { get; set; }

    public string? FormOfFood { get; set; }

    public bool? IsSpecialCondition { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public decimal? Muac { get; set; }

    public decimal? Ulna { get; set; }
}
