﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class BirthRecord
{
    public string RegistrationNo { get; set; } = null!;

    public string? MotherMedicalNo { get; set; }

    public string? MotherRegistrationNo { get; set; }

    public string? TimeOfBirth { get; set; }

    public string? SrbornAt { get; set; }

    public string? BornAtDescription { get; set; }

    public string? SrsingleTwin { get; set; }

    public string? TwinNo { get; set; }

    public string? SrbirthMethod { get; set; }

    public string? SrcaesarMethod { get; set; }

    public string? SrbornCondition { get; set; }

    public string? SrbirthComplication { get; set; }

    public string? SrdeathCondition { get; set; }

    public string? SrbirthIndication { get; set; }

    public decimal? BirthPregnancyAge { get; set; }

    public decimal? Length { get; set; }

    public decimal? Weight { get; set; }

    public decimal? ApgarScore1 { get; set; }

    public decimal? ApgarScore2 { get; set; }

    public decimal? ApgarScore3 { get; set; }

    public decimal? HeadCircumference { get; set; }

    public decimal? ChestCircumference { get; set; }

    public string? CertificateNo { get; set; }

    public string? FatherName { get; set; }

    public string? FatherSsn { get; set; }

    public DateTime? FatherBirthOfDate { get; set; }

    public string? StreetName { get; set; }

    public string? District { get; set; }

    public string? City { get; set; }

    public string? County { get; set; }

    public string? State { get; set; }

    public string? ZipCode { get; set; }

    public string? Sroccupation { get; set; }

    public string? PhoneNo { get; set; }

    public string? FaxNo { get; set; }

    public string? MobilePhoneNo { get; set; }

    public string? Email { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? Notes { get; set; }

    public decimal? AbdomenCircumference { get; set; }

    public short? ChildNo { get; set; }

    public bool? IsEyesSmeared { get; set; }

    public string? EyesSmearedNotes { get; set; }

    public bool? IsAnusExamined { get; set; }

    public string? AnusExaminedNotes { get; set; }

    public string? Srcongenital { get; set; }

    public bool? IsMarriageLicense { get; set; }
}
