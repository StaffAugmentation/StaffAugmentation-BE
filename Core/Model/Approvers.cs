using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;
public class Approvers
{
    public int Id { get; set; }

    //[Column("app_FirstName")]
    public string AppFirstName { get; set; } = null!;
    //[Column("app_LastName")]
    public string AppLastName { get; set; } = null!;

    //public virtual ICollection<PaymentCandidateFee> PaymentCandidateFees { get; } = new List<PaymentCandidateFee>();

    //public virtual ICollection<PaymentCandidateReferralFee1> PaymentCandidateReferralFee1s { get; } = new List<PaymentCandidateReferralFee1>();

    //public virtual ICollection<ScfpExpensesPayment> ScfpExpensesPayments { get; } = new List<ScfpExpensesPayment>();

    //public virtual ICollection<ScqtmExpensesPayment> ScqtmExpensesPayments { get; } = new List<ScqtmExpensesPayment>();

    //public virtual ICollection<SctmptmExpensesPayment> SctmptmExpensesPayments { get; } = new List<SctmptmExpensesPayment>();
}