using Core.Model;

namespace Core.ViewModel;

public class ProfileLevelViewModel
{
    public int Id { get; set; }
    public double? NumberOfDays { get; set; }
    public string? OnSite { get; set; }
    public double? DailyPrice { get; set; }
    public bool? isDeleted { get; set; }
    public int Penalty_Days { get; set; }
    public string? PenaltyComment { get; set; }
    public double? Penalty_Amount { get; set; }
    public string? OtherExpertiseRequired { get; set; }
    public int idProfileTemp { get; set; }
    public int? BRProfileIdCurrency { get; set; }
    public int? PenaltyIdCurrency { get; set; }
    public bool? ApplyItEquipment { get; set; }
    public string? BankAccount { get; set; }
    public DateTime? Validity_Date { get; set; }
    public bool? ApplyContractorPremises { get; set; }
    public string? PlaceOfExecution { get; set; }
    public DateTime? dt_SentToCustomer { get; set; }
    public DateTime? dt_FO_Deadline { get; set; }
    public DateTime? dt_Proposal_Is_Submitted_To_Customer { get; set; }
    public DateTime? dt_FO_Is_Submitted_To_Customer { get; set; }
    public DateTime? dt_ChangeOffer { get; set; }
    public DateTime? dt_ChangeOffer_Is_Submitted_To_Customer { get; set; }
    public DateTime? dt_Refusal { get; set; }
    public DateTime? dt_Acceptance { get; set; }

    public Profile? Profile { get; set; }
    public Level? level { get; set; }
    public Category? category { get; set; }
    public RequestFormStatus? RequestFormStatus { get; set; }
    public ServiceLevelCategory? ServiceLevelCategory { get; set; }
    public Company? Company { get; set; }
    public CandidateStatus? Status { get; set; }
    


}
