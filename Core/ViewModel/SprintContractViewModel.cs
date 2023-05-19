using Core.Model;

namespace Core.ViewModel;

public class SprintContractViewModel
{

    public int Id { get; set; }
    public string? RequestNumber { get; set; }
    public string? Ressource { get; set; }
    public double? ConsultantCost { get; set; }
    public int? idTypeOfContractSC { get; set; }
    public double? RemainingDays { get; set; }
    public double? DailyMargin { get; set; }
    public double? ManagementFee { get; set; }
    public bool? ManagementFeeInvoiceNumber { get; set; }
    public string? ContractStatus { get; set; }
    public string? LoginCreation { get; set; }
    public DateTime? DateCreation { get; set; }
    public bool SCPTM { get; set; }
    public string? LoginUpdate { get; set; }
    public bool isStaffAugmentation { get; set; }
    public string? DarwinCode { get; set; }
    public DateTime? DateUpdate { get; set; }
    public string? PerformanceComment { get; set; }
    public string? PurchaseOrderReferencePay { get; set; }
    public DateTime? Termination_NoticeDate { get; set; }
    public DateTime? Termination_EffectiveDate { get; set; }
    public bool? Termination_NoticePeriodRespected { get; set; }
    public double? TerminationPenalty { get; set; }
    public bool? TerminationPenaltyRetainer { get; set; }
    public string? TerminationCause { get; set; }
    public bool? TerminationDeCommitment { get; set; }
    public double? TerminationNumberOfDays { get; set; }
    public bool? TerminationDeductionOfServices { get; set; }
    public int? IdPTMOwner { get; set; }
    public string? PTMOwnerAddress { get; set; }
    public double? PTMOwnerRate { get; set; }
    public string? PTMPurchaseOrderReferencePay { get; set; }
    public string? ThirdPartyPurchaseOrderReferencePay { get; set; }
    public string? MFPurchaseOrderReferencePay { get; set; }
    public string? MissionPurchaseOrderReferencePay { get; set; }
    public string? idConsultantContractStatus { get; set; }

    public virtual BusinessRequest? BusinessRequest { get; set; }
    public virtual TypeOfContractSC? TypeOfContractSC { get; set; }

}
