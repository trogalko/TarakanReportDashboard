﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class JournalGroupDetail
{
    public int JournalDetailId { get; set; }

    public int JournalGroupId { get; set; }

    public string JournalJournalCode { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
