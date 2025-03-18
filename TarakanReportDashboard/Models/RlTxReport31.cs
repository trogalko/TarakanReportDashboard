﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class RlTxReport31
{
    public string RlTxReportNo { get; set; } = null!;

    public int RlMasterReportItemId { get; set; }

    public int? PasienAwal { get; set; }

    public int? PasienMasuk { get; set; }

    public int? PasienKeluarHidup { get; set; }

    public int? PasienKeluarMatiK48 { get; set; }

    public int? PasienKeluarMatiL48 { get; set; }

    public int? LamaRawat { get; set; }

    public int? PasienAkhir { get; set; }

    public int? HariRawat { get; set; }

    public int? Vvip { get; set; }

    public int? Vip { get; set; }

    public int? I { get; set; }

    public int? Ii { get; set; }

    public int? Iii { get; set; }

    public int? KelasKhusus { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public int? PasienPindahan { get; set; }

    public int? PasienDipindahkan { get; set; }
}
