using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("SCFollowUP_TMPTM_Payment_DaysWorkedProvision")]
public class SCFollowUPTMPTMPaymentDaysWorkedProvision
{
    public int Id { get; set; }
    public int IdPayment { get; set; }
    public int IdDWProvision { get; set; }
    public int IdThirdParty { get; set; }
    public double? NbdaysPaid { get; set; }
    public double ThirdPartyCost { get; set; }
    public double AmountPaid { get; set; }
    public string OERPProjectCode { get; set; }
    public int? IdBRProfile { get; set; }

    public virtual PaymentSC PaymentSC { get; set; }
    public virtual SCFollowUPTMPTMDaysWorkedProvision SCFollowUPTMPTMDaysWorkedProvision { get; set; }
}