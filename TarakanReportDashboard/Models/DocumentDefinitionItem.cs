﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class DocumentDefinitionItem
{
    public int DocumentDefinitionId { get; set; }

    public int DocumentFilesId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
