﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class AzureApplicationProfile
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long AzureSubscriptionId { get; set; }

    public long AzureApplicationId { get; set; }

    public string? Description { get; set; }

    public virtual AzureApplication AzureApplication { get; set; } = null!;

    public virtual ICollection<AzureProfile> AzureProfiles { get; set; } = new List<AzureProfile>();

    public virtual ICollection<AzureResource> AzureResources { get; set; } = new List<AzureResource>();

    public virtual AzureSubscription AzureSubscription { get; set; } = null!;
}
