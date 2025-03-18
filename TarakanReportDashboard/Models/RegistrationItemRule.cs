﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class RegistrationItemRule
{
    public string RegistrationNo { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string? SrguarantorRuleType { get; set; }

    public decimal AmountValue { get; set; }

    public bool? IsValueInPercent { get; set; }

    public bool? IsInclude { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public bool? IsToGuarantor { get; set; }

    public decimal? OutpatientAmountValue { get; set; }

    public decimal? EmergencyAmountValue { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
