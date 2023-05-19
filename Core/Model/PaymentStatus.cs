using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

public partial class PaymentStatus
{
    public string Id { get; set; } = null!;

    [Column("StatusValue")]
    public string Value { get; set; } = null!;

    [Column("PaymentModule")]
    public string Module { get; set; } = null!;

    //public virtual ICollection<PaymentCandidateFee> PaymentCandidateFees { get; } = new List<PaymentCandidateFee>();

    //public virtual ICollection<PaymentCandidateReferralFee1> PaymentCandidateReferralFee1s { get; } = new List<PaymentCandidateReferralFee1>();

    //public virtual ICollection<ScDaysWorkedByMonth> ScDaysWorkedByMonths { get; } = new List<ScDaysWorkedByMonth>();
}