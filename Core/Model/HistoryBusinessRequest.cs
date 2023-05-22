using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

public class HistoryBusinessRequest
{
    [Key]
    [Column("idHistory")]
    public int Id { get; set; }
    public int IdBR { get; set; }
    public string IdType { get; set; }
    public string IdStatus { get; set; }
    public string IdTypeOfContract { get; set; }
    public string IdPlaceOfDelivery { get; set; }

    [Column("Request_number")]
    public string RequestNumber { get; set; }

    [Column("DG_Department_Id")]
    public string DgDepartmentId { get; set; }

    [Column("DG_Email")]
    public string DgEmail { get; set; }

    [Column("Contact_Name")]
    public string ContactName { get; set; }

    [Column("idSourceBR")]
    public string IdSourceBr { get; set; }

    [Column("dt_RFReceived")]
    public DateTime? DtRfReceived { get; set; }

    [Column("dt_Acknowledgement")]
    public DateTime? DtAcknowledgement { get; set; }

    [Column("dt_Deadline")]
    public DateTime? DtDeadline { get; set; }

    [Column("dt_ProposalDeadline")]
    public DateTime? DtProposalDeadline { get; set; }
    public bool? Proximity { get; set; }

    [Column("Expected_Project_Start_Date")]
    public DateTime? ExpectedProjectStartDate { get; set; }

    [Column("TOTAL_man_days")]
    public double? TotalManDays { get; set; }
    public string IdCompany { get; set; }

    [Column("Specific_Contract_Number")]
    public string? SpecificContractNumber { get; set; }

    [Column("dt_SC_Is_Received")]
    public DateTime? DtScIsReceived { get; set; }

    [Column("dt_SC_Is_signed")]
    public DateTime? DtScIsSigned { get; set; }

    [Column("Project_Start_Date")]
    public DateTime? ProjectStartDate { get; set; }

    [Column("Max_End_Date")]
    public DateTime? MaxEndDate { get; set; }

    [Column("Number_Of_Days")]
    public double? NumberOfDays { get; set; }

    [Column("Bank_Account")]
    public string BankAccount { get; set; }

    [Column("Daily_Price")]
    public double? DailyPrice { get; set; }

    [Column("Total_Price")]
    public double? TotalPrice { get; set; }
    public string LoginCreation { get; set; }
    public DateTime? DateCreation { get; set; }
    public string LoginUpdate { get; set; }
    public DateTime? DateUpdate { get; set; }
    public string TypeBRValue { get; set; }
    public string TechnicalContact { get; set; }
    public string LinkedBR { get; set; }
    public string CommentUpdate { get; set; }
    public string Profiles { get; set; }

    [Column("Ext_Max_End_Date")]
    public DateTime? ExtMaxEndDate { get; set; }
    public string Levels { get; set; }
    public string OpenIntendedComment { get; set; }
    public double? AdditionalBudget { get; set; }
    public string SpecificClientCode { get; set; }
    public string UserAction { get; set; }
    public string Category { get; set; }
    public bool? IsSCCreated { get; set; }
    public bool IsCascade { get; set; }

    [Column("dt_AcknowledgementDeadline")]
    public DateTime? DtAcknowledgementDeadline { get; set; }
    public string GeneralComment { get; set; }
    public double? SubtotalPrice { get; set; }
    public double? GeneralBudget { get; set; }

    [Column("AdditionalBudget_Currency")]
    public string AdditionalBudgetCurrency { get; set; }

    [Column("Service_Level_Category_Value")]
    public string ServiceLevelCategoryValue { get; set; }

    [Column("Validity_Date")]
    public string ValidityDate { get; set; }

    [Column("dt_ReceptionDraft")]
    public DateTime? DtReceptionDraft { get; set; }

    [Column("Draft_Approval")]
    public bool? DraftApproval { get; set; }

    [Column("Draft_ContractApprover")]
    public string DraftContractApprover { get; set; }

    [Column("dt_DraftApproval")]
    public DateTime? DtDraftApproval { get; set; }
}