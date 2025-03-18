﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class VwServiceUnitBooking
{
    public string BookingNo { get; set; } = null!;

    public string ParamedicId { get; set; } = null!;

    public string? Medicalno { get; set; }

    public string? PatientName { get; set; }

    public string Sex { get; set; } = null!;

    public string MobilePhoneNo { get; set; } = null!;

    public string ParamedicName { get; set; } = null!;

    public string ParamedicInitial { get; set; } = null!;

    public DateTime BookingDateTimeFrom { get; set; }

    public DateTime BookingDateTimeTo { get; set; }

    public string Weekdays { get; set; } = null!;

    public string PhoneNo { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public string RoomId { get; set; } = null!;

    public string RoomName { get; set; } = null!;

    public string? Notes { get; set; }

    public string AnestesiPlan { get; set; } = null!;
}
