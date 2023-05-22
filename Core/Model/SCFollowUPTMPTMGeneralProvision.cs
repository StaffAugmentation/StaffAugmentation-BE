using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("SCFollowUP_TMPTM_GeneralProvision")]
public class SCFollowUPTMPTMGeneralProvision
{
    public int Id { get; set; }
    public int IdSC { get; set; }
    public int ConsultantId { get; set; }
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

    [Column("id_temp")]
    public string TempId { get; set; }
    public string OERPProjectCode { get; set; }
    public int? IdBRProfile { get; set; }
    public string SuppDocPath { get; set; }
    public virtual SprintContract SprintContract { get; set; }
    public virtual ICollection<SCFollowUPTMPTMInvoiceGeneralProvision> SCFollowUPTMPTMInvoiceGeneralProvision { get; set; }
    public virtual ICollection<SCFollowUPTMPTMPaymentGeneralProvision> SCFollowUPTMPTMPaymentGeneralProvision { get; set; }
}