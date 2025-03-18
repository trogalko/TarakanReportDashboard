﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class ServiceFeeRsucdr
{
    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string TariffComponentId { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public decimal FeeDirektur { get; set; }

    public decimal FeeStruktural { get; set; }

    public decimal FeeMedis { get; set; }

    public decimal FeeUnit { get; set; }

    public decimal FeePemerataan { get; set; }

    public string? CreateByUserId { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public bool? IsParamedicFeeRemun { get; set; }

    public bool? IsParamedicEmergency { get; set; }

    public int RemunId { get; set; }
}
