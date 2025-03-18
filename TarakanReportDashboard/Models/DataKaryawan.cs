using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class DataKaryawan
{
    public int Id { get; set; }

    public string? Nama { get; set; }

    public DateTime? Dob { get; set; }

    public string? Nik { get; set; }
}
