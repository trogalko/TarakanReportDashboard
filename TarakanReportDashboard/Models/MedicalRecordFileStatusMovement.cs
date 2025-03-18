using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class MedicalRecordFileStatusMovement
{
    public string RegistrationNo { get; set; } = null!;

    public string LastPositionServiceUnitId { get; set; } = null!;

    public DateTime? LastPositionDateTime { get; set; }

    public string? LastPositionUserId { get; set; }
}
