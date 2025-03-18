﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class NutritionCareTransHd
{
    public string TransactionNo { get; set; } = null!;

    public DateTime NutritionCareTransDateTime { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string CreateByUserId { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }
}
