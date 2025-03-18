﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class TmpBillInterm
{
    public int? Ident { get; set; }

    public string? RegistrationNo { get; set; }

    public string? TransactionNo { get; set; }

    public string? SequenceNo { get; set; }

    public string? ReferenceNo { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? IntermbillNo { get; set; }

    public string? ItemId { get; set; }

    public string? ItemName { get; set; }

    public string? BillingGroupId { get; set; }

    public string? BillingGroupName { get; set; }

    public string? TariffComponentId { get; set; }

    public decimal? ChargeQuantity { get; set; }

    public string? SritemUnit { get; set; }

    public decimal? PatientAmount { get; set; }

    public decimal? GuarantorAmount { get; set; }

    public decimal? PatientDiscountAmount { get; set; }

    public decimal? GuarantorDiscountAmount { get; set; }

    public decimal? Cprice { get; set; }

    public decimal? CdiscountAmount { get; set; }

    public string? ParamedicCollectionName { get; set; }

    public string? ServiceUnitId { get; set; }

    public string? ClassId { get; set; }

    public int? ComponentCount { get; set; }

    public string? RregistrationNo { get; set; }
}
