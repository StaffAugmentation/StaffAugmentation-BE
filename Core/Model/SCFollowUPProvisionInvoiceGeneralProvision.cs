using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("SCFollowUP_Provision_Invoice_GeneralProvision")]
public class SCFollowUPProvisionInvoiceGeneralProvision
{
    public int Id { get; set; }
    public int IdInvoice { get; set; }
    public int IdProvision { get; set; }
    public double? AmountInvoiced { get; set; }
    public string OERPProjectCode { get; set; }
    public int? IdConsultant { get; set; }
    public int? IdBRProfile { get; set; }

    public virtual SCFollowUPProvisionInvoice SCFollowUPProvisionInvoice { get; set; }
    public virtual SCFollowUPProvisionGeneralProvision SCFollowUPProvisionGeneralProvision { get; set; }
}