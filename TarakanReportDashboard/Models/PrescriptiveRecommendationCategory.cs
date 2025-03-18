﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class PrescriptiveRecommendationCategory
{
    public int CategoryId { get; set; }

    public string Name { get; set; } = null!;

    public int? ParentCategory { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<PrescriptiveRecommendation> PrescriptiveRecommendations { get; set; } = new List<PrescriptiveRecommendation>();
}
