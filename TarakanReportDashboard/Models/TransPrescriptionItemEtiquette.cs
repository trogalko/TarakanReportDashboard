﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class TransPrescriptionItemEtiquette
{
    public string PrescriptionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string ItemName { get; set; } = null!;

    public string ConsumeMethod { get; set; } = null!;

    public string Keeping { get; set; } = null!;

    public string? SpecificInfo { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public bool IsDrugOutside { get; set; }

    public string? CreateUserId { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? LastUpdateUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public int? NumberOfCopies { get; set; }

    public string? BatchNumber { get; set; }
}
