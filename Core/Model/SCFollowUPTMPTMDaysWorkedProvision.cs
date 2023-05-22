using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("SCFollowUP_TMPTM_DaysWorkedProvision")]
public class SCFollowUPTMPTMDaysWorkedProvision
{
    public int Id { get; set; }
    public int IdSC { get; set; }
    public string Month { get; set; }
    public double? NumberOfDaysWorked { get; set; }
    public double? RemainingDays { get; set; }
    public int? ConsultantId { get; set; }
    public int? TypeOfContractId { get; set; }
    public double? ConsultantCost { get; set; }
    public int? idCompany { get; set; }
    public string idPaymentStatus { get; set; }
    public string idInvoicingStatus { get; set; }
    public string idPTMPaymentStatus { get; set; }
    public string idThirdPartyPaymentStatus { get; set; }
    public string idMFPaymentStatus { get; set; }
    public string IdMFInvoicingStatus { get; set; }
    public DateTime? DateCreation { get; set; }
    public string LoginCreation { get; set; }
    public DateTime? DateUpdate { get; set; }
    public string LoginUpdate { get; set; }
    public bool? isTransferCompany { get; set; }
    public bool? isConsultantCostChanged { get; set; }
    public double salesPrice { get; set; }
    public int? idTransformation { get; set; }
    public int? idTransferCompany { get; set; }
    public string OERPProjectCode { get; set; }
    public bool? isThirdPartyRateChanged { get; set; }
    public double? ThirdPartyRate { get; set; }
    public bool? isPTMRateChanged { get; set; }
    public double? PTMRate { get; set; }
    public int? idBRProfile { get; set; }
    public string SuppDocPath { get; set; }
    public DateTime? DateUploadFile { get; set; }
    public virtual ICollection<SCFollowUPTMPTMInvoiceDaysWorkedProvision> SCFollowUP_TMPTM_Invoice_DaysWorkedProvision { get; set; }
    public virtual ICollection<SCFollowUPTMPTMPaymentDaysWorkedProvision> SCFollowUPTMPTMPaymentDaysWorkedProvision { get; set; }
    public virtual SprintContract SprintContract { get; set; }
}