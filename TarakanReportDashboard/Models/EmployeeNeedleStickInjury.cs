﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class EmployeeNeedleStickInjury
{
    public string TransactionNo { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string ReferenceNo { get; set; } = null!;

    public string ExposedArea { get; set; } = null!;

    public string Reason { get; set; } = null!;

    public bool IsBlood { get; set; }

    public bool IsFluidSperm { get; set; }

    public bool IsVaginalSecretions { get; set; }

    public bool IsCerebrospinal { get; set; }

    public bool IsUrine { get; set; }

    public bool IsFaeces { get; set; }

    public bool IsOfficerHiv { get; set; }

    public bool IsOfficerHbv { get; set; }

    public bool IsOfficerHcv { get; set; }

    public string OfficerImunizationHistory { get; set; } = null!;

    public string Chronology { get; set; } = null!;

    public string Recomendation { get; set; } = null!;

    public string PatientId { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public string Diagnose { get; set; } = null!;

    public bool IsPatientHiv { get; set; }

    public bool IsPatientHbv { get; set; }

    public bool IsPatientHcv { get; set; }

    public string PatientImunizationHistory { get; set; } = null!;

    public bool IsSpo { get; set; }

    public bool IsUsingApd { get; set; }

    public string KnownBy { get; set; } = null!;

    public DateTime? FollowUpDate { get; set; }

    public string? FollowUpNotes { get; set; }

    public string? FollowUpBy { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserId { get; set; }

    public bool? IsVerified { get; set; }

    public DateTime? VerifiedDateTime { get; set; }

    public string? VerifiedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
