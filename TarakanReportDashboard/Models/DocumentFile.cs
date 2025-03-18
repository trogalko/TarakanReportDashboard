﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class DocumentFile
{
    public int DocumentFilesId { get; set; }

    public string DocumentName { get; set; } = null!;

    public string DocumentNumber { get; set; } = null!;

    public string? FileTemplateName { get; set; }

    public bool IsQuality { get; set; }

    public bool IsLegible { get; set; }

    public bool IsSign { get; set; }

    public bool? IsActive { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public bool? IsUsedForAnalysis { get; set; }

    public bool? IsUsedForGuarantorChecklist { get; set; }

    public string? ProgramId { get; set; }
}
