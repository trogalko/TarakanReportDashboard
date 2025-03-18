﻿using System;
using System.Collections.Generic;

namespace TarakanReportDashboard.Models;

public partial class TransPayment
{
    public string PaymentNo { get; set; } = null!;

    public string TransactionCode { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public string? PaymentReferenceNo { get; set; }

    public string ReferenceNo { get; set; } = null!;

    public DateTime PaymentDate { get; set; }

    public string PaymentTime { get; set; } = null!;

    public string? PrintReceiptAsName { get; set; }

    public decimal TotalPaymentAmount { get; set; }

    public decimal RemainingAmount { get; set; }

    public byte PrintNumber { get; set; }

    public string PaymentReceiptNo { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public bool? IsPrinted { get; set; }

    public bool IsVoid { get; set; }

    public bool IsApproved { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public bool? IsVisiteDownPayment { get; set; }

    public string? GuarantorId { get; set; }

    public bool? IsToGuarantor { get; set; }

    public string? Srpromotion { get; set; }

    public string? Initial { get; set; }

    public bool? ReceiptIsReturned { get; set; }

    public DateTime? ApproveDate { get; set; }

    public string? ApproveByUserId { get; set; }

    public DateTime? VoidDate { get; set; }

    public string? VoidByUserId { get; set; }

    public DateTime? LastPrintedDateTime { get; set; }

    public string? LastPrintedByUserId { get; set; }

    public bool? IsGuarantorVerified { get; set; }

    public bool? IsPackagePaymentPerVisit { get; set; }

    public string? CashManagementNo { get; set; }

    public string? PatientId { get; set; }

    public string? VoidReason { get; set; }

    public bool? IsExternalPayment { get; set; }

    public virtual ICollection<TransPaymentItem> TransPaymentItems { get; set; } = new List<TransPaymentItem>();

    public virtual ICollection<TransPaymentReceiptItem> TransPaymentReceiptItems { get; set; } = new List<TransPaymentReceiptItem>();
}
