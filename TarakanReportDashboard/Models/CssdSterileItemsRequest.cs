﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class CssdSterileItemsRequest
{
    public string RequestNo { get; set; } = null!;

    public DateTime RequestDate { get; set; }

    public string FromServiceUnitId { get; set; } = null!;

    public string? FromRoomId { get; set; }

    public string? SenderById { get; set; }

    public string SenderBy { get; set; } = null!;

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
