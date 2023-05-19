using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("SC_DaysWorkedByMonth")]
public partial class ScDaysWorkedByMonth
{
    public int Id { get; set; }

    [Column("IdSC")]
    public int SprintContractId { get; set; }

    public string Month { get; set; } = null!;

    public double? NumberOfDaysWorked { get; set; }

    public double? NumberOfDaysForecast { get; set; }

    public double? RemainingDays { get; set; }

    public string? PaymentStatusId { get; set; }

    public string? InvoicingStatusId { get; set; }

    public string? SuppDocPath { get; set; }

    public DateTime? DateUploadFile { get; set; }

    public int? ConsultantId { get; set; }

    public int? TypeOfContractId { get; set; }

    public DateTime? DateCreation { get; set; }

    public string? LoginCreation { get; set; }

    public DateTime? DateUpdate { get; set; }

    public string? LoginUpdate { get; set; }

    public string? PTMPaymentStatusId { get; set; }

    public string? ThirdPartyPaymentStatusId { get; set; }

    public string? MFPaymentStatusId { get; set; }

    public string? MFInvoicingStatusId { get; set; }

    public bool IsTransferCompany { get; set; }

    [Column("IdCompany")]
    public int? CompanyId { get; set; }

    public double ConsultantCost { get; set; }

    public bool IsConsultantCostChanged { get; set; }

    public double? NoInvoiceableDays { get; set; }

    public double? NoPayableDays { get; set; }

    public double? RealInvoiceableDays { get; set; }

    public double? RealPayableDays { get; set; }

    public string? OERPProjectCode { get; set; }

    public double? InitialForecast { get; set; }

    public bool? IsThirdPartyRateChanged { get; set; }

    public double? ThirdPartyRate { get; set; }

    public bool? IsPTMRateChanged { get; set; }

    public double? PTMRate { get; set; }

    [Column("idBRProfile")]
    public int? BRProfileId { get; set; }

    public virtual Company? Company { get; set; }

    public virtual InvoicingStatus? InvoicingStatus { get; set; }

    public virtual PaymentStatus? PaymentStatus { get; set; }

    public virtual SprintContract SprintContract { get; set; } = null!;

    public virtual ICollection<InvoiceDaysWorked> InvoiceDaysWorked { get; } = new List<InvoiceDaysWorked>();

    //public virtual ICollection<PaymentScDaysWorked> PaymentScDaysWorkeds { get; } = new List<PaymentScDaysWorked>();

    //public virtual ICollection<ScDaysWorkedByMonthDetail> ScDaysWorkedByMonthDetails { get; } = new List<ScDaysWorkedByMonthDetail>();
}