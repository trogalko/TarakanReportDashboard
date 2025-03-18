using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class ParamedicFeeByNumberOfPatientsRangeAmount
{
    public int CounterId { get; set; }

    public short? MinAmount { get; set; }

    public short? MaxAmount { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
