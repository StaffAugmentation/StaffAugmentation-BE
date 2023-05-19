using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

public partial class PaymentSC
{
    public int Id { get; set; }
    public DateTime InvoiceDate { get; set; }
    public string InvoiceReference { get; set; } = null!;
    public DateTime? InvoicingPeriodFrom { get; set; }
    public DateTime? InvoicingPeriodTo { get; set; }
    public double InvoiceAmount { get; set; }
    public double VATAmount { get; set; }
    public string TypeOfCost { get; set; } = null!;
    public string BankAccount { get; set; } = null!;
    public string? BICSwift { get; set; }
    public string? POReference { get; set; }
    public string? InvoiceComment { get; set; }
    public string? PathInvoiceDoc { get; set; }
    public DateTime DateCreation { get; set; }
    public string LoginCreation { get; set; } = null!;
    public DateTime DateUpdate { get; set; }
    public string LoginUpdate { get; set; } = null!;
    public bool IsPTMSurcharge { get; set; }
    public bool OnHold { get; set; }
    public string IdTypePayment { get; set; } = null!;
    public double? MFAmount { get; set; }
    public DateTime? DtPaymentSchedule { get; set; }
    public int? OriginPaymentId { get; set; }
    public string PaymentNature { get; set; } = null!;
    public int? IdApprover { get; set; }
    public string? PathApprovalProof { get; set; }
    public string IdPaymentStatus { get; set; } = null!;
    public int IdSC { get; set; }
    public string CurrencyCostValue { get; set; } = null!;
    public string LegalEntityName { get; set; } = null!;
    public string? VATLegal { get; set; }
    public string? SAPVendor { get; set; }

    [ForeignKey("IdTypePayment")]
    public virtual TypePayment? TypePayment { get; set; }

    //public virtual ICollection<PaymentScDaysWorked> PaymentScDaysWorkeds { get; } = new List<PaymentScDaysWorked>();
    //public virtual ICollection<PaymentScOerpcode> PaymentScOerpcodes { get; } = new List<PaymentScOerpcode>();
    //public virtual ICollection<ScfollowUpTmptmPaymentDaysWorkedProvision> ScfollowUpTmptmPaymentDaysWorkedProvisions { get; } = new List<ScfollowUpTmptmPaymentDaysWorkedProvision>();
    //public virtual ICollection<ScfollowUpTmptmPaymentGeneralProvision> ScfollowUpTmptmPaymentGeneralProvisions { get; } = new List<ScfollowUpTmptmPaymentGeneralProvision>();
}