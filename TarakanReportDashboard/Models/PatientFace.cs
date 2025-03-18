﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class PatientFace
{
    public string PatientId { get; set; } = null!;

    public int FacePositionXc { get; set; }

    public int FacePositionYc { get; set; }

    public int FacePositionW { get; set; }

    public float FacePositionAngle { get; set; }

    public int Eye1X { get; set; }

    public int Eye1Y { get; set; }

    public int Eye2X { get; set; }

    public int Eye2Y { get; set; }

    public byte[] Template { get; set; } = null!;

    public byte[] Image { get; set; } = null!;

    public byte[] FaceImage { get; set; } = null!;

    public DateTime? LastCreatedDateTime { get; set; }

    public string? LastCreatedUserId { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }

    public string? LastUpdatedUserId { get; set; }
}
