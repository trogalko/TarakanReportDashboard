﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class RlTxReport51
{
    public string RlTxReportNo { get; set; } = null!;

    public int RlMasterReportItemId { get; set; }

    public int? Jumlah { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
