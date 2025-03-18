﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class IncomeJournalStatus
{
    public int Id { get; set; }

    public string Month { get; set; } = null!;

    public string Year { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public int? JournalId { get; set; }
}
