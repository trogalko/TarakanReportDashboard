using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class ServiceFeeExecutedFormula
{
    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string TariffComponentId { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public string? ExecutedFormula { get; set; }
}
