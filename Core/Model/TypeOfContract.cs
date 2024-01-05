using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

public partial class TypeOfContract
{
    public int Id { get; set; }

    public string ValueId { get; set; } = null!;

    public bool WithCategory { get; set; }

    public bool StaffLeader { get; set; }

    public bool? IsPartner { get; set; }

    public bool IsActive { get; set; }

    public double? NoticePeriod { get; set; }

    [Column("Date_FO_Deadline_Days")]
    public int? DateFoDeadlineDays { get; set; }

    [Column("Normal_Working_Day")]
    public double? NormalWorkingDay { get; set; }

    [Column("Validity_Days")]
    public int? ValidityDays { get; set; }

    [Column("Payment_Terms_Id")]
    public string? PaymentTermsId { get; set; }

    [Column("Currency_Id")]
    public int? CurrencyId { get; set; }

    [Column("Default_YN_Deadline")]
    public int? DefaultYnDeadline { get; set; }

    [Column("Default_Proposal_Deadline")]
    public int? DefaultProposalDeadline { get; set; }

    [Column("FWC_Signature_Date")]
    public DateTime? FwcSignatureDate { get; set; }

    [Column("FWC_Duration")]
    public int? FwcDuration { get; set; }

    [Column("FWC_Automatic_Renewal")]
    public int? FwcAutomaticRenewal { get; set; }

    [Column("FWC_Automatic_Renewal_Date")]
    public DateTime? FwcAutomaticRenewalDate { get; set; }

    [Column("FWC_End_Date")]
    public DateTime? FwcEndDate { get; set; }

    [Column("FWC_End_Date_Performance")]
    public DateTime? FwcEndDatePerformance { get; set; }

    [Column("FWC_End_Date_Extension")]
    public DateTime? FwcEndDateExtension { get; set; }

    [Column("FWC_Code")]
    public string? FwcCode { get; set; }

    [Column("MF_Chargeability")]
    public double? MfChargeability { get; set; }
    
    [Column("Staff_Invoicing_All")]
    public bool? StaffInvoicingAll { get; set; }

    [Column("Indexation_Request_Deadline_Date")]
    public DateTime? IndexationRequestDeadlineDate { get; set; }

    [Column("Indexation_Applicable_From")]
    public DateTime? IndexationApplicableFrom { get; set; }

    [Column("Reporting_Client")]
    public bool? ReportingClient { get; set; }

    [Column("PTM_surcharge")]
    public double? PtmSurcharge { get; set; }

    public string Mfinvoiced { get; set; } = null!;

    public bool IsCascade { get; set; }

    public int? IdLeadingCompany { get; set; }

    [Column("PTM_surcharge_Rate")]
    public double? PtmSurchargeRate { get; set; }

    [Column("Normal_Performance")]
    public string NormalPerformance { get; set; } = null!;

    [Column("Normal_HoursPerDay")]
    public double NormalHoursPerDay { get; set; }

    [Column("Outside_Performance")]
    public string OutsidePerformance { get; set; } = null!;

    [Column("Outside_HoursPerDay")]
    public double OutsideHoursPerDay { get; set; }

    public bool? WithServiceLevelCategory { get; set; }

    [Column("number_candidate")]
    public int? NumberCandidate { get; set; }

    public double? ItEquipment { get; set; }

    public string? TypeInvoice { get; set; }

    public string? InvoicingPeriod { get; set; }

    public double? MinByQuarterly { get; set; }

    public double? MaxByQuarterly { get; set; }

    public double? MinTotalAmountContract { get; set; }

    public double? ContractorPremises { get; set; }

    public int? NumberOfDigits { get; set; }

    public string? UserEmail { get; set; }

    public string? RecruitmentEmail { get; set; }

    //public virtual ICollection<BusinessRequest> BusinessRequests { get; } = new List<BusinessRequest>();

    public virtual CurrencyParam? Currency { get; set; }

    //public virtual ICollection<FwcBusinessRequestRequiredField> FwcBusinessRequestRequiredFields { get; } = new List<FwcBusinessRequestRequiredField>();

    //public virtual ICollection<FwcTemplate> FwcTemplates { get; } = new List<FwcTemplate>();

    //public virtual ICollection<FwcserviceTypeMf> FwcserviceTypeMfs { get; } = new List<FwcserviceTypeMf>();

    public virtual PaymentTerm? PaymentTerms { get; set; }

    //public virtual ICollection<ProfileTypeOfContract> ProfileTypeOfContracts { get; } = new List<ProfileTypeOfContract>();

    //public virtual ICollection<RecruitmentResp> RecruitmentResps { get; } = new List<RecruitmentResp>();

    //public virtual ICollection<UsersTypeOfContract> UsersTypeOfContracts { get; } = new List<UsersTypeOfContract>();
}