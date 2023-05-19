using Core.Model;

namespace Core.ViewModel;

public class SCDaysWorkedByMonthViewModel
{
    public int Id { get; set; }
    public int IdSC { get; set; }
    public string? Month { get; set; }
    public double? NumberOfDaysWorked { get; set; }
    public double? NumberOfDaysForecast { get; set; }
    public double? RemainingDays { get; set; }
    public string? IdPaymentStatus { get; set; }
    public string? IdInvoicingStatus { get; set; }
    public bool IsChange { get; set; }
    public bool IsDeleted { get; set; }
    public string? LoginCreation { get; set; }
    public string? IdPTMPaymentStatus { get; set; }
    public string? IdThirdPartyPaymentStatus { get; set; }
    public string? IdMFInvoicingStatus { get; set; }
    public string? idMFPaymentStatus { get; set; }
    public double? NbDaysPaid { get; set; }
    public bool IsTransferCompany { get; set; }
    public bool IsChangeDWCN { get; set; }
    public bool IsChangeAbsence { get; set; }
    public double ConsultantCost { get; set; }
    public bool isConsultantCostChanged { get; set; }
    public bool newCostApplied { get; set; }
    public int? ConsultantId { get; set; }
    public string? ConsultantName { get; set; }
    public bool IsPTMOwnerEveris { get; set; }
    public double? OldNbDays { get; set; }
    public double? NoPayableDays { get; set; }
    public double? NoInvoiceableDays { get; set; }
    public double? RealInvoicableDays { get; set; }
    public double? RealPayableDays { get; set; }
    public string? OERPProjectCode { get; set; }
    public double? SumForecastByCons { get; set; }
    public bool IsChangedOERPDW { get; set; }
    public double InitialForecast { get; set; }
    public bool? IsPTMRateChanged { get; set; }
    public bool? IsThirdPartyRateChanged { get; set; }
    public double? PTMRate { get; set; }
    public double? ThirdPartyRate { get; set; }
    public bool NewPTMApplied { get; set; }
    public bool NewTPApplied { get; set; }
    public int? IdProfileTemp { get; set; }
    public int? IdBRProfile { get; set; }

    public List<DaysWorkedDocumentViewModel>? Attachments { get; set; }
    public List<AbsenceDaysViewModel>? Absences { get; set; }

    public TypeOfContractSC? TypeOfContract { get; set; }
    public Company? Company { get; set; }

}
