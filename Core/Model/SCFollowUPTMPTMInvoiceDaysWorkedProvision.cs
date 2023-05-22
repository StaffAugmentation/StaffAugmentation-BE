using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("SCFollowUP_TMPTM_Invoice_DaysWorkedProvision")]
public class SCFollowUPTMPTMInvoiceDaysWorkedProvision
{
    public int Id { get; set; }
    public int IdInvoice { get; set; }
    public int IdDWProvision { get; set; }
    public int IdConsultant { get; set; }
    public double? NbdaysInvoiced { get; set; }
    public double SalesPrice { get; set; }
    public double AmountInvoiced { get; set; }
    public string OERPProjectCode { get; set; }
    public int? idBRProfile { get; set; }
    public virtual InvoiceSC InvoicesSC { get; set; }
    public virtual SCFollowUPTMPTMDaysWorkedProvision SCFollowUP_TMPTM_DaysWorkedProvision { get; set; }
}