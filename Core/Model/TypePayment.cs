namespace Core.Model;

public partial class TypePayment
{
    public string? Id { get; set; }
    public string? ValueId { get; set; }

    public virtual ICollection<PaymentSC> PaymentSC { get; } = new List<PaymentSC>();
    //public virtual ICollection<ScfpExpensesPayment> ScfpExpensesPayments { get; } = new List<ScfpExpensesPayment>();
    //public virtual ICollection<ScposExpensesPayment> ScposExpensesPayments { get; } = new List<ScposExpensesPayment>();
    //public virtual ICollection<ScqtmExpensesPayment> ScqtmExpensesPayments { get; } = new List<ScqtmExpensesPayment>();
    //public virtual ICollection<SctmptmExpensesPayment> SctmptmExpensesPayments { get; } = new List<SctmptmExpensesPayment>();
}