using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("SCFollowUP_Provision_Invoice")]
public class SCFollowUPProvisionInvoice
{
    public int Id { get; set; }
    public int IdSC { get; set; }
    public DateTime InvoiceDate { get; set; }
    public double InvoiceAmount { get; set; }
    public string InvoiceClient { get; set; }
    public string EverisEntity { get; set; }
    public string OERPInvoiceCode { get; set; }
    public string IdDraft { get; set; }
    public string ClientPONumber { get; set; }
    public string TypeInvoice { get; set; }
    public double? MFValue { get; set; }
    public int? OriginInvoiceId { get; set; }
    public string InvoiceNature { get; set; }
    public string idInvoicingStatus { get; set; }
    public string InvoiceDescription { get; set; }
    public DateTime DateCreation { get; set; }
    public string LoginCreation { get; set; }
    public DateTime DateUpdate { get; set; }
    public string LoginUpdate { get; set; }
    public bool? IsGlobalInvoice { get; set; }
    public virtual ICollection<SCFollowUPProvisionInvoiceOERPCode> SCFollowUPProvisionInvoiceOERPCode { get; set; }
    public virtual ICollection<SCFollowUPProvisionInvoiceDaysWorkedDetail> SCFollowUPProvisionInvoiceDaysWorkedDetail { get; set; }
    public virtual ICollection<SCFollowUPProvisionInvoiceGeneralProvision> SCFollowUP_Provision_Invoice_GeneralProvision { get; set; }
}