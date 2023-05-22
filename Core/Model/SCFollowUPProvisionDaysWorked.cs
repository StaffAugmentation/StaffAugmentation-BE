using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("SCFollowUP_Provision_DaysWorked")]
public class SCFollowUPProvisionDaysWorked
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
    public Nullable<System.DateTime> DateCreation { get; set; }
    public string LoginCreation { get; set; }
    public DateTime? DateUpdate { get; set; }
    public string LoginUpdate { get; set; }
    public bool? IsTransferCompany { get; set; }
    public bool? IsConsultantCostChanged { get; set; }
    public string OERPProjectCode { get; set; }
    public bool? IsThirdPartyRateChanged { get; set; }
    public double? ThirdPartyRate { get; set; }
    public int? IdBRProfile { get; set; }
    public string SuppDocPath { get; set; }
    public DateTime? DateUploadFile { get; set; }

    public virtual SCFollowUPProvision SCFollowUPProvision { get; set; }
    public virtual ICollection<SCFollowUPProvisionInvoiceDaysWorkedDetail> SCFollowUPProvisionInvoiceDaysWorkedDetail { get; set; }
    public virtual ICollection<SCFollowUPProvisionPaymentDaysWorkedDetail> SCFollowUPProvisionPaymentDaysWorkedDetail { get; set; }
}