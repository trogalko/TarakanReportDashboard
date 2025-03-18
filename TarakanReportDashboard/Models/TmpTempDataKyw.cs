﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class TmpTempDataKyw
{
    public string? PatientId { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public string? RegistrationNo { get; set; }

    public DateTime? DischargeDate { get; set; }

    public decimal? Nilai { get; set; }

    public decimal? Diskon { get; set; }

    public decimal? Bayar { get; set; }

    public string? UserId { get; set; }

    public DateTime? TimeStamp { get; set; }
}
