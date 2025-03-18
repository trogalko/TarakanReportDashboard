using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class ConditionIh
{
    public string? ConditionId { get; set; }

    public string? EncounterId { get; set; }

    public string? RegistrationNo { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
