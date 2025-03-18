﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class PersonalImage
{
    public int PersonId { get; set; }

    public byte[]? Photo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
