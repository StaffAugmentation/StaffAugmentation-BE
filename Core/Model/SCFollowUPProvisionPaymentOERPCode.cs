using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("SCFollowUP_Provision_Payment_OERPCode")]
public class SCFollowUPProvisionPaymentOERPCode
{
    public int Id { get; set; }
    public int IdPayment { get; set; }
    public string OERPProjectCode { get; set; }
    public double AmountPaid { get; set; }

    public virtual SCFollowUPProvisionPayment SCFollowUPProvisionPayment { get; set; }
}