﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class GuarantorDocumentChecklist
{
    public string GuarantorId { get; set; } = null!;

    public string SrregistrationType { get; set; } = null!;

    public string SrdocumentChecklist { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
