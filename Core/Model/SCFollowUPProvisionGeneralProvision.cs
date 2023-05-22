using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("SCFollowUP_Provision_GeneralProvision")]
public class SCFollowUPProvisionGeneralProvision
{
    public int Id { get; set; }
    public int IdSC { get; set; }
    public string Description { get; set; }
    public double ProvisionAmount { get; set; }
    public double RemainingAmount { get; set; }
    public string IdPaymentStatus { get; set; }
    public string IdInvoicingStatus { get; set; }
    public string IdMFPaymentStatus { get; set; }
    public string IdMFInvoicingStatus { get; set; }
    public DateTime? DateCreation { get; set; }
    public string LoginCreation { get; set; }
    public DateTime? DateUpdate { get; set; }
    public string LoginUpdate { get; set; }
    public string id_temp { get; set; }
    public string OERPProjectCode { get; set; }
    public int? ConsultantId { get; set; }
    public int? idBRProfile { get; set; }
    public string SuppDocPath { get; set; }

    public virtual SCFollowUPProvision SCFollowUPProvision { get; set; }
    public virtual ICollection<SCFollowUPProvisionInvoiceGeneralProvision> SCFollowUPProvisionInvoiceGeneralProvision { get; set; }
    public virtual ICollection<SCFollowUPProvisionPaymentGeneralProvision> SCFollowUPProvisionPaymentGeneralProvision { get; set; }
}