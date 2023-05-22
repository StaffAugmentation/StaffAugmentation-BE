using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("SCFollowUP_Provision_Payment")]
public class SCFollowUPProvisionPayment
{
    public int Id { get; set; }
    public int IdSC { get; set; }
    public string ThirdPartyType { get; set; }
    public int ThirdPartyId { get; set; }
    public DateTime InvoiceDate { get; set; }
    public string InvoiceReference { get; set; }
    public double InvoiceAmount { get; set; }
    public double VATAmount { get; set; }
    public string TypeOfCost { get; set; }
    public string BankAccount { get; set; }
    public string BICSWIFT { get; set; }
    public string POReference { get; set; }
    public string InvoiceComment { get; set; }
    public string PathInvoiceDoc { get; set; }
    public DateTime DateCreation { get; set; }
    public string LoginCreation { get; set; }
    public DateTime DateUpdate { get; set; }
    public string LoginUpdate { get; set; }
    public bool IsPTMSurcharge { get; set; }
    public bool OnHold { get; set; }
    public string IdTypePayment { get; set; }
    public double? MFAmount { get; set; }

    [Column("dt_PaymentSchedule")]
    public DateTime? DtPaymentSchedule { get; set; }
    public int? OriginPaymentId { get; set; }
    public string PaymentNature { get; set; }
    public int idApprover { get; set; }
    public string PathApprovalProof { get; set; }
    public string IdPaymentStatus { get; set; }

    [Column("idTemp")]
    public string IdTemp { get; set; }
    public string CurrencyCostValue { get; set; }
    public string LegalEntityName { get; set; }

    [Column("SAP_vendor")]
    public string SAPVendor { get; set; }
    public string VATLegal { get; set; }
    public virtual ICollection<SCFollowUPProvisionPaymentOERPCode> SCFollowUPProvisionPaymentOERPCode { get; set; }
    public virtual ICollection<SCFollowUPProvisionPaymentGeneralProvision> SCFollowUPProvisionPaymentGeneralProvision { get; set; }
    public virtual ICollection<SCFollowUPProvisionPaymentDaysWorkedDetail> SCFollowUPProvisionPaymentDaysWorkedDetail { get; set; }
}