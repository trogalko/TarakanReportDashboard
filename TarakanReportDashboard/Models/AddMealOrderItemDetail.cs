﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class AddMealOrderItemDetail
{
    public string OrderNo { get; set; } = null!;

    public string FoodId { get; set; } = null!;

    public short? Qty { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
