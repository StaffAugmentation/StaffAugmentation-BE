using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("SCFollowUP_Provision_Payment_GeneralProvision")]
public class SCFollowUPProvisionPaymentGeneralProvision
{
    public int Id { get; set; }
    public int IdPayment { get; set; }
    public int IdProvision { get; set; }
    public double? AmountPaid { get; set; }
    public string OERPProjectCode { get; set; }
    public virtual SCFollowUPProvisionPayment SCFollowUPProvisionPayment { get; set; }
    public virtual SCFollowUPProvisionGeneralProvision SCFollowUPProvisionGeneralProvision { get; set; }
}