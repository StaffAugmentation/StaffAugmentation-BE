using Core.Model;

namespace Core.ViewModel;

public class PaymentSCViewModel
{
    public int Id { get; set; }
    public int IdDaysWorked { get; set; }
    public string? RequestNumber { get; set; }
    public DateTime InvoiceDate { get; set; }
    public string? InvoiceReference { get; set; }
    public DateTime? InvoicingPeriodFrom { get; set; }
    public DateTime? InvoicingPeriodTo { get; set; }
    public double TotalNumberDays { get; set; }
    public double InvoiceAmount { get; set; }
    public double VATAmount { get; set; }
    public DateTime? PaymentSchedule { get; set; }
    public string? TypeOfCost { get; set; }
    public string? BankAccount { get; set; }
    public string? BICSWIFT { get; set; }
    public string? Approver { get; set; }
    public string? POReference { get; set; }
    public string? SAPVendor { get; set; }
    public string? InvoiceComment { get; set; }
    public string? pathInvoiceDoc { get; set; }
    public DateTime DateCreation { get; set; }
    public string? LoginCreation { get; set; }
    public string? Month { get; set; }
    public DateTime? DateUpdate { get; set; }
    public string? LoginUpdate { get; set; }
    public bool IsChange { get; set; }
    public bool IsDeleted { get; set; }
    public bool IsDocChanged { get; set; }
    public string? FileNamePayment { get; set; }
    public bool IsPTMSurcharge { get; set; }
    public bool OnHold { get; set; }
    public double InvoiceCost { get; set; }
    public string? IdTypePayment { get; set; }
    public string? TypeBR { get; set; }
    public int? OriginPaymentId { get; set; }
    public int IdApprover { get; set; }
    public string? PaymentNature { get; set; }
    public string? ApprovalFileName { get; set; }
    public bool IsApprovalDocChanged { get; set; }
    public bool IsPaymentAccelerated { get; set; }
    public int IdSC { get; set; }
    public string? LegalName { get; set; }
    public string? CurrencyCostValue { get; set; }
    public string? VATLegal { get; set; }
    public string? CurrencyTotalPrice { get; set; }

    public TypePayment? TypePayment { get; set; }
    public TypeOfContract? TypeOfContract { get; set; }

    public IEnumerable<Object>? ListDWPaid { get; set; }
    public IEnumerable<Object>? ListProvisionDaysWorked { get; set; }
    public IEnumerable<Object>? ListGeneralProvision { get; set; }
    public List<ConsultantDataPaymentViewModel>? ConsultantData { get; set; }
    public IEnumerable<Object>? ListDetailsFP { get; set; }
    public IEnumerable<Object>? ListDetailsQTM { get; set; }
    //public List<PaymentSC_OERPCode> ListOERP { get; set; }
    //public List<SCFollowUP_Provision_Payment_OERPCode> ListOERPProvision { get; set; }
    //public List<SCPOS_Expenses_Payment_OERPCode> ListOERPMissionPOS { get; set; }
    //public List<SCFollowUP_FP_Milestone_Payment_OERPCode> ListOERPFP { get; set; }
    //public List<SCFP_Expenses_Payment_OERPCode> ListOERPFPMission { get; set; }
    //public List<SCFollowUP_QTM_Subtask_Payment_OERPCode> ListOERPQTM { get; set; }
    //public List<SCQTM_Expenses_Payment_OERPCode> ListOERPQTMMission { get; set; }
    //public List<SCTMPTM_Expenses_Payment_OERPCode> ListOERPMission { get; set; }
    //public List<DWProvisionPaymentViewModel> DWProvisionData { get; set; }
    //public List<GenaralProvisionPaymentViewModel> GeneralProvisionData { get; set; }
}