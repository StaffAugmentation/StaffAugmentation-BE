using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("SCFollowUP_TMPTM_Payment_GeneralProvision")]
public class SCFollowUPTMPTMPaymentGeneralProvision
{
    public int id { get; set; }
    public int idPayment { get; set; }
    public int idProvision { get; set; }
    public int idThirdParty { get; set; }
    public Nullable<double> AmountPaid { get; set; }
    public string OERPProjectCode { get; set; }
    public Nullable<int> idBRProfile { get; set; }

    public virtual PaymentSC PaymentSC { get; set; }
    public virtual SCFollowUPTMPTMGeneralProvision SCFollowUPTMPTMGeneralProvision { get; set; }
}