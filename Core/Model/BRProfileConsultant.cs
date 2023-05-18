using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("BR_ProfileConsultant")]
public partial class BRProfileConsultant
{
    [Key]
    public int Id { get; set; }

    public int IdBRConsultant { get; set; }

    public int? IdBRProfile { get; set; }

    [Column("ConsCost_Margin")]
    public double? ConsCostMargin { get; set; }

    [Column("Third_Party_rate")]
    public double? ThirdPartyRate { get; set; }

    public int? SubContractorId { get; set; }

    public int? TypeOfContractId { get; set; }

    public double? AgreedRate { get; set; }

    public DateTime? ExpectedStartDate { get; set; }

    public string? SubcontractorName { get; set; }

    [Column("TPRate_idCurrency")]
    public int? TPRateIdCurrency { get; set; }

    [Column("ConsCost_idCurrency")]
    public int? ConsCostIdCurrency { get; set; }

    public int? IdPTMOwner { get; set; }

    [Column("PTMOwnerAdress")]
    public string? PTMOwnerAddress { get; set; }

    public double? PTMOwnerRate { get; set; }

    public string? IdTypeInvolvement { get; set; }

    [Column("Nbr_Days")]
    public double? NbrDays { get; set; }

    public double? TotalPriceMargin { get; set; }

    public double? TotalCost { get; set; }

    [Column("Termination_NoticeDate")]
    public DateTime? TerminationNoticeDate { get; set; }

    [Column("Termination_EffectiveDate")]
    public DateTime? TerminationEffectiveDate { get; set; }

    [Column("Termination_NoticePeriodRespected")]
    public bool? TerminationNoticePeriodRespected { get; set; }

    [Column("Termination_Penality")]
    public double? TerminationPenalty { get; set; }

    [Column("Termination_PenaltyRetainer")]
    public bool? TerminationPenaltyRetainer { get; set; }

    [Column("Termination_Cause")]
    public string? TerminationCause { get; set; }

    [Column("Termination_Decommitment")]
    public bool? TerminationDecommitment { get; set; }

    [Column("Termination_NumberOfDays")]
    public double? TerminationNumberOfDays { get; set; }

    [Column("Termination_DeductionOfServices")]
    public bool? TerminationDeductionOfServices { get; set; }

    public string IdConsultantContractStatus { get; set; } = null!;

    [Column("PTMOwnerRate_idCurrency")]
    public int? PTMOwnerRateIdCurrency { get; set; }

    [Column("TotalCost_idCurrency")]
    public int? TotalCostIdCurrency { get; set; }

    public double? DaysOfTraining { get; set; }

    [ForeignKey("SubContractorId")]
    public virtual SubContractor? SubContractor { get; set; }

    [ForeignKey("TypeOfContractId")]
    public virtual TypeOfContractSC? TypeOfContractSC { get; set; }
}