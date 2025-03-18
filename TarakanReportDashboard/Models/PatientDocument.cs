﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class PatientDocument
{
    public long PatientDocumentId { get; set; }

    public string PatientId { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public string FileAttachName { get; set; } = null!;

    public string DocumentName { get; set; } = null!;

    public DateTime? DocumentDate { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public byte[]? SmallImage { get; set; }

    public string? OriFileName { get; set; }

    public string? OriPath { get; set; }

    public bool? IsUpload { get; set; }

    public bool? IsDeleted { get; set; }

    public string? ReferenceNo { get; set; }

    public string? SrdocumentCategory { get; set; }

    public bool? IsClaimDocument { get; set; }
}
