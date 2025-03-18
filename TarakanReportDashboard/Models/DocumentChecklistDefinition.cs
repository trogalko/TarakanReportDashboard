using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class DocumentChecklistDefinition
{
    public string SrdocumentChecklist { get; set; } = null!;

    public int DocumentFilesId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
