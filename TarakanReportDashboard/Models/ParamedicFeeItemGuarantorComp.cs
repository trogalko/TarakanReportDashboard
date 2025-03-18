﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class ParamedicFeeItemGuarantorComp
{
    public string ParamedicId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string GuarantorId { get; set; } = null!;

    public string TariffComponentId { get; set; } = null!;

    public bool IsParamedicFeeUsePercentage { get; set; }

    public decimal ParamedicFeeAmount { get; set; }

    public decimal ParamedicFeeAmountReferral { get; set; }

    public bool IsDeductionFeeUsePercentage { get; set; }

    public decimal DeductionFeeAmount { get; set; }

    public decimal DeductionFeeAmountReferral { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
