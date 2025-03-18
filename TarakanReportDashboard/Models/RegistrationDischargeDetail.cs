﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class RegistrationDischargeDetail
{
    public string RegistrationNo { get; set; } = null!;

    public string? ParamedicId { get; set; }

    public string? ParamedicName { get; set; }

    public string? SrunitIntended { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? OtherExamination { get; set; }
}
