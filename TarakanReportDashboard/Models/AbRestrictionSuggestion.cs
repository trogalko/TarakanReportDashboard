﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class AbRestrictionSuggestion
{
    public string AbRestrictionId { get; set; } = null!;

    public int AbLevel { get; set; }

    public string? SuggestionNote { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
