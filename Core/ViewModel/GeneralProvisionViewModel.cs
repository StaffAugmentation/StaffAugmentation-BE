using Core.Model;

namespace Core.ViewModel;

public class GeneralProvisionViewModel
{
    public int Id { get; set; }
    public int SprintContractId { get; set; }
    public string? Description { get; set; }
    public double ProvisionAmount { get; set; }
    public double RemainingAmount { get; set; }
    public DateTime? DateCreation { get; set; }
    public string? LoginCreation { get; set; }
    public DateTime? DateUpdate { get; set; }
    public string? LoginUpdate { get; set; }
    public string? idTemp { get; set; }
    public int ConsultantId { get; set; }
    public int BRProfileId { get; set; }
    public string? OERPProjectCode { get; set; }

    public PaymentStatus? PaymentStatus { get; set; }
    public InvoicingStatus? InvoicingStatus { get; set; }
    public PaymentStatus? PTMPaymentStatus { get; set; }
    public PaymentStatus? ThirdPartyPaymentStatus { get; set; }
    public PaymentStatus? MFPaymentStatus { get; set; }
    public InvoicingStatus? MFInvoicingStatus { get; set; }
    public PaymentStatus? companyPaymentStatus { get; set; }
    public List<GeneralProvisionDocumentViewModel>? ListAttachment { get; set; }
}
