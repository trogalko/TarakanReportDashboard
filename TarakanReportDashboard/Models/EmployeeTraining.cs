﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class EmployeeTraining
{
    public int EmployeeTrainingId { get; set; }

    public string EmployeeTrainingName { get; set; } = null!;

    public string TrainingLocation { get; set; } = null!;

    public string TrainingOrganizer { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }

    public int TotalHour { get; set; }

    public bool IsInHouseTraining { get; set; }

    public decimal CreditPoint { get; set; }

    public decimal TrainingFee { get; set; }

    public decimal? SponsorFee { get; set; }

    public bool IsScheduledTraining { get; set; }

    public int TargetAttendance { get; set; }

    public string Note { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public int? ReferenceId { get; set; }

    public bool? IsProposal { get; set; }

    public string? SractivityType { get; set; }

    public DateTime? CertificateValidityPeriod { get; set; }

    public bool? IsCommitmentToWork { get; set; }

    public short? LengthOfService { get; set; }

    public DateTime? StartServiceDate { get; set; }

    public DateTime? EndServiceDate { get; set; }

    public string? SrtrainingFinancingSources { get; set; }

    public DateTime? EvaluationDate { get; set; }

    public decimal? DurationHour { get; set; }

    public decimal? DurationMinutes { get; set; }

    public string? SremployeeTrainingPointType { get; set; }

    public string? SremployeeTrainingDateSeparator { get; set; }

    public string? SractivitySubType { get; set; }

    public decimal? PlanningCosts { get; set; }
}
