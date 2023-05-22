using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("SCFollowUP_Provision_Invoice_OERPCode")]
public class SCFollowUPProvisionInvoiceOERPCode
{
    public int Id { get; set; }
    public int IdInvoice { get; set; }
    public string OERPProjectCode { get; set; }
    public double AmountInvoiced { get; set; }

    public virtual SCFollowUPProvisionInvoice SCFollowUPProvisionInvoice { get; set; }
}