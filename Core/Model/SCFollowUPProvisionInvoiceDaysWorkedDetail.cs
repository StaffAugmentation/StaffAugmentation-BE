using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("SCFollowUP_Provision_Invoice_DaysWorkedDetail")]
public class SCFollowUPProvisionInvoiceDaysWorkedDetail
{
    public int Id { get; set; }
    public int IdInvoice { get; set; }
    public int IdDaysWorked { get; set; }
    public int IdConsultant { get; set; }
    public double? NbdaysInvoiced { get; set; }
    public double AmountInvoiced { get; set; }
    public double SalesPrice { get; set; }
    public string OERPProjectCode { get; set; }
    public int? IdBRProfile { get; set; }
    public virtual SCFollowUPProvisionInvoice SCFollowUP_Provision_Invoice { get; set; }
    public virtual SCFollowUPProvisionDaysWorked SCFollowUP_Provision_DaysWorked { get; set; }
}