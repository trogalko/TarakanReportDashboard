﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class SalaryComponentRuleMatrix
{
    public int SalaryComponentRuleMatrixId { get; set; }

    public int SalaryComponentId { get; set; }

    public int SalaryRuleComponentId { get; set; }

    public string SroperandType { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
