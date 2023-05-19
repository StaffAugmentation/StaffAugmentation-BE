using Core.Model;

namespace Core.ViewModel;

public class ProvisionDWResultViewModel
{
    public int Id { get; set; }
    public int IdSC { get; set; }
    public string? Month { get; set; }
    public double? NumberOfDaysWorked { get; set; }
    public double? RemainingDays { get; set; }
    public int? ConsultantId { get; set; }
    public int? TypeOfContractId { get; set; }
    public double? ConsultantCost { get; set; }
    public int? CompanyId { get; set; }

    public string? LoginCreation { get; set; }
    public string? oldFileName { get; set; }

    public DateTime? DateCreation { get; set; }

    public DateTime? DateUpdate { get; set; }
    public string? LoginUpdate { get; set; }
    public bool? isTransferCompany { get; set; }
    public bool? isConsultantCostChanged { get; set; }
    public bool? NewCostApplied { get; set; }
    public string? ConsultantName { get; set; }
    public bool IsChange { get; set; }
    public bool IsDeleted { get; set; }
    public int? BRProfileId { get; set; }
    public bool IsDocChangedDWProvision { get; set; }
    public bool IsPTMOwnerEveris { get; set; }
    public double SalesPrice { get; set; }
    public int IdTransformation { get; set; }
    public int? IdTransferCompany { get; set; }
    public string? OERPProjectCode { get; set; }
    public bool? IsPTMRateChanged { get; set; }
    public bool? IsThirdPartyRateChanged { get; set; }
    public double? PTMRate { get; set; }
    public double? ThirdPartyRate { get; set; }
    public bool NewPTMApplied { get; set; }
    public bool NewTPApplied { get; set; }

    public TypeOfContractSC? TypeOfContract { get; set; }
    public Company? Company { get; set; }
    public PaymentStatus? PaymentStatus { get; set; }
    public InvoicingStatus? InvoicingStatus { get; set; }
    public PaymentStatus? PTMPaymentStatus { get; set; }
    public PaymentStatus? ThirdPartyPaymentStatus { get; set; }
    public PaymentStatus? MFPaymentStatus { get; set; }
    public InvoicingStatus? MFInvoicingStatus { get; set; }

    public List<DaysWorkedDocumentViewModel>? Attachment { get; set; }


}