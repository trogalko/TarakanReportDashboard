﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class KiosKroom
{
    public string KiosKroomId { get; set; } = null!;

    public string? ServiceUnitId { get; set; }

    public string? ParamedicId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public string? CreateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? KioskRoomName { get; set; }
}
