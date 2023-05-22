using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("SCFollowUP_TMPTM_Invoice_GeneralProvision")]
public class SCFollowUPTMPTMInvoiceGeneralProvision
{
    public int Id { get; set; }
    public int IdInvoice { get; set; }
    public int IdProvision { get; set; }
    public double? AmountInvoiced { get; set; }
    public int IdConsultant { get; set; }
    public string OERPProjectCode { get; set; }
    public int? IdBRProfile { get; set; }
    public virtual InvoiceSC InvoiceSC { get; set; }
    public virtual SCFollowUPTMPTMGeneralProvision SCFollowUPTMPTMGeneralProvision { get; set; }
}