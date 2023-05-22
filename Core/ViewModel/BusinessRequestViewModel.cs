using Core.Model;

namespace Core.ViewModel
{
    public class BusinessRequestViewModel
    {
        public int Id { get; set; }
        public int IdType { get; set; }
        public int IdStatus { get; set; }
        public int IdTypeOfContract { get; set; }
        public int IdPlaceOfDelivery { get; set; }
        public int IdCategorie { get; set; }
        public string? IdSourceBR { get; set; }
        public string? IdRequestFormStatus { get; set; }
        public string? Requestnumber { get; set; }
        public string? DGEmail { get; set; }
        public string? FinalCandidateEmail { get; set; }
        public string? ContactName { get; set; }
        public string? RequestOrExtension { get; set; }
        public DateTime? DtRFReceived { get; set; }
        public DateTime? DtAcknowledgement { get; set; }
        public DateTime? DtDeadline { get; set; }
        public DateTime? DtSentToCustomer { get; set; }
        public DateTime? DtProposalDeadline { get; set; }
        public DateTime? DtProposalIsSubmittedToCustomer { get; set; }
        public DateTime? DtFOIsSubmittedToCustomer { get; set; }
        public bool? Proximity { get; set; }
        public string? OtherExpertiseRequired { get; set; }
        public DateTime? ExpectedProjectStartDate { get; set; }
        public double? TOTALManDays { get; set; }

        public string? FinalCandidate { get; set; }

        public string? SpecificContractNumber { get; set; }
        public DateTime? DtSCIsReceived { get; set; }
        public DateTime? DtSCIsSigned { get; set; }
        public DateTime? ProjectStartDate { get; set; }
        public DateTime? MaxEndDate { get; set; }
        public DateTime? ExtMaxEndDate { get; set; }
        public DateTime? MaxEndDateSC { get; set; }

        public double? NumberOfDays { get; set; }
        public string? BankAccount { get; set; }
        public DateTime? ValidityDate { get; set; }
        public double? DailyPrice { get; set; }
        public double? TotalPrice { get; set; }
        public string? LoginCreation { get; set; }
        public DateTime? DateCreation { get; set; }
        public string? LoginUpdate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public DateTime? DtFODeadline { get; set; }
        public string? TechnicalContact { get; set; }
        public string? LinkedBR { get; set; }
        public string? Comment { get; set; }

        public double? AdditionalBudget { get; set; }
        public double? Penalty { get; set; }
        public string? PenaltyComment { get; set; }

        public string? OpenIntendedComment { get; set; }
        public string? SpecificClientCode { get; set; }
        public string? ResponseMessage { get; set; }
        public DateTime? DtChangeOffer { get; set; }
        public DateTime? DtChangeOfferIsSubmittedToCustomer { get; set; }
        public double? ConsultantCost { get; set; }
        public double MFRate { get; set; }
        public bool IsCascade { get; set; }
        public double? MFMaxAmount { get; set; }
        public double? PenaltyDays { get; set; }
        public bool SCExist { get; set; }
        public bool HasTransfer { get; set; }
        public double? PTMOwnerRate { get; set; }
        public DateTime? DtAcceptance { get; set; }
        public DateTime? DtRefusal { get; set; }

        public DateTime? DtAcknowledgementDeadline { get; set; }
        public string? GeneralComment { get; set; }
        public int? AdditionalBudgetIdCurrency { get; set; }
        public double? SubtotalPrice { get; set; }
        public double? GeneralBudget { get; set; }
        public int IdSC { get; set; }
        public int? IdServiceLevelCategory { get; set; }
        public DateTime? DtReceptionDraft { get; set; }
        public bool? DraftApproval { get; set; }
        public string? DraftContractApprover { get; set; }
        public DateTime? DtDraftApproval { get; set; }

        public virtual Department? Department { get; set; }
        public virtual Company? Company { get; set; }
        public virtual Category? Category { get; set; }
        public virtual Level? Level { get; set; }
        public virtual PlaceOfDelivery? PlaceOfDelivery { get; set; }
        public virtual StatusBr? StatusBR { get; set; }
        public virtual BrType? TypeBR { get; set; }
        public virtual Model.Type? Type { get; set; }
        public virtual TypeOfContract? TypeOfContract { get; set; }
        public virtual Profile? Profile { get; set; }
        public virtual BrSource? BRSource { get; set; }
        public virtual RequestFormStatus? RequestFormStatus { get; set; }
        public Company? LeadingCompany { get; set; }
        public CurrencyRateParam? CurrencySalesPrice { get; set; }
        public CurrencyRateParam? CurrencyAdditionalBudget { get; set; }
        public TypeOfCost? Cost { get; set; }
        public TypeOfContractSC? TypeOfContractSC { get; set; }

        public Object? SubcontractorData { get; set; }
        public Object? ConsultantData { get; set; }
    }
}