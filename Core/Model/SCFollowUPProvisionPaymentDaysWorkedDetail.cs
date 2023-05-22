using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("SCFollowUP_Provision_Payment_DaysWorkedDetail")]
public class SCFollowUPProvisionPaymentDaysWorkedDetail
{
    public int Id { get; set; }
    public int IdPayment { get; set; }
    public int IdDaysWorked { get; set; }
    public double? NbdaysPaid { get; set; }
    public double AmountPaid { get; set; }
    public double ConsultantCost { get; set; }
    public string OERPProjectCode { get; set; }
    public int? idBRProfile { get; set; }

    public virtual SCFollowUPProvisionPayment SCFollowUPProvisionPayment { get; set; }
    public virtual SCFollowUPProvisionDaysWorked SCFollowUPProvisionDaysWorked { get; set; }
}