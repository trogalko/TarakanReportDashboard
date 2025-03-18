﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class Bpjshfisparamedicschedule
{
    public string BpjsParamedicId { get; set; } = null!;

    public string BpjsServiceUnitId { get; set; } = null!;

    public string BpjsDay { get; set; } = null!;

    public string? BpjsParamedicName { get; set; }

    public string? BpjsStartHour { get; set; }

    public string? BpjsEndHour { get; set; }

    public int? BpjsMaxCapacity { get; set; }

    public string? BpjsSubSpecialityCode { get; set; }

    public string? BpjsSubSpecialityName { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? IsActive { get; set; }

    public string? LegacyWorkingTime { get; set; }

    public string? BpjsDayName { get; set; }

    public DateTime? BpjsScheduleDate { get; set; }
}
