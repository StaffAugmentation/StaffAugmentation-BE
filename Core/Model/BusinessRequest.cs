using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model
{
    public partial class BusinessRequest
    {
        public int Id { get; set; }

        public int? IdType { get; set; }

        //public string IdStatus { get; set; } = null!;

        public int IdTypeOfContract { get; set; }

        public int IdPlaceOfDelivery { get; set; }

        [Column("Request_number")]
        public string? RequestNumber { get; set; }

        [Column("DG_Department_Id")]
        public int? DgDepartmentId { get; set; }

        [Column("DG_Email")]
        public string? DgEmail { get; set; }

        [Column("Contact_Name")]
        public string? ContactName { get; set; }

        public string? IdSourceBr { get; set; }

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

        [Column("Daily_Price")]
        public double? DailyPrice { get; set; }

        [Column("Total_Price")]
        public double? TotalPrice { get; set; }

        public string? LoginCreation { get; set; }

        public DateTime? DateCreation { get; set; }

        public string? LoginUpdate { get; set; }

        public DateTime? DateUpdate { get; set; }

        public bool IsDeleted { get; set; }

        public int IdTypeBr { get; set; }

        public string? TechnicalContact { get; set; }

        public string? LinkedBr { get; set; }

        [Column("Ext_Max_End_Date")]
        public DateTime? ExtMaxEndDate { get; set; }

        public string? OpenIntendedComment { get; set; }

        public double? AdditionalBudget { get; set; }

        public DateTime? NextActionDate { get; set; }

        public string? SpecificClientCode { get; set; }

        public bool? IsScCreated { get; set; }

        public bool IsCascade { get; set; }

        [Column("dt_AcknowledgementDeadline")]
        public DateTime? DtAcknowledgementDeadline { get; set; }

        public string? GeneralComment { get; set; }

        public double? SubtotalPrice { get; set; }

        public double? GeneralBudget { get; set; }

        [Column("AdditionalBudget_idCurrency")]
        public int? AdditionalBudgetIdCurrency { get; set; }

        [Column("dt_ReceptionDraft")]
        public DateTime? DtReceptionDraft { get; set; }

        [Column("Draft_Approval")]
        public bool? DraftApproval { get; set; }

        [Column("Draft_ContractApprover")]
        public string? DraftContractApprover { get; set; }

        [Column("dt_DraftApproval")]
        public DateTime? DtDraftApproval { get; set; }

        //public virtual ICollection<BrCandidateList> BrCandidateLists { get; } = new List<BrCandidateList>();

        //public virtual ICollection<BrConsultant> BrConsultants { get; } = new List<BrConsultant>();

        //public virtual ICollection<BrDocument> BrDocuments { get; } = new List<BrDocument>();

        //public virtual ICollection<BrProfile> BrProfiles { get; } = new List<BrProfile>();

        //public virtual ICollection<BrSubontractor> BrSubontractors { get; } = new List<BrSubontractor>();

        //public virtual ICollection<ChangeCompany> ChangeCompanies { get; } = new List<ChangeCompany>();

        [ForeignKey("DgDepartmentId")]
        public virtual Department? Department { get; set; }

        [ForeignKey("IdPlaceOfDelivery")]
        public virtual PlaceOfDelivery PlaceOfDelivery { get; set; } = null!;

        [ForeignKey("IdSourceBr")]
        public virtual BrSource? BrSource { get; set; }

        //[ForeignKey("IdStatus")]
        //public virtual StatusBr StatusBr { get; set; } = null!;

        [ForeignKey("IdTypeBR")]
        public virtual BrType BrType { get; set; } = null!;

        [ForeignKey("idType")]
        public virtual Type? Type { get; set; }

        [ForeignKey("idTypeOfContract")]
        public virtual TypeOfContract TypeOfContract { get; set; } = null!;

        //public virtual ICollection<ScfollowUpFp> ScfollowUpFps { get; } = new List<ScfollowUpFp>();

        //public virtual ICollection<ScfollowUpProvision> ScfollowUpProvisions { get; } = new List<ScfollowUpProvision>();

        //public virtual ICollection<ScfollowUpQtm> ScfollowUpQtms { get; } = new List<ScfollowUpQtm>();

        //public virtual ICollection<SprintContract> SprintContracts { get; } = new List<SprintContract>();
    }
}