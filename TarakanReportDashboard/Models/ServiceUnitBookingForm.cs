﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class ServiceUnitBookingForm
{
    public string BookingNo { get; set; } = null!;

    public string QuestionFormId { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
