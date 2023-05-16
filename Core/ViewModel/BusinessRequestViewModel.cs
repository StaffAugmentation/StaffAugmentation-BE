using Core.Model;

namespace Core.ViewModel;

public class BusinessRequestViewModel
{
    public int Id { get; set; }
    public int IdType { get; set; }
    //public int IdStatus { get; set; }
    public int IdTypeOfContract { get; set; }
    public int IdPlaceOfDelivery { get; set; }
    public int IdCategorie { get; set; }
    public string IdSourceBR { get; set; }
    public string IdRequestFormStatus { get; set; }
    public string Request_number { get; set; }
    public virtual Department Department { get; set; }
    public string DG_Email { get; set; }
    public string Final_Candidate_Email { get; set; }
    public string Contact_Name { get; set; }
    public string RequestOrExtension { get; set; }
    public Nullable<System.DateTime> Dt_RFReceived { get; set; }
    public Nullable<System.DateTime> Dt_Acknowledgement { get; set; }
    public Nullable<System.DateTime> Dt_Deadline { get; set; }
    public Nullable<System.DateTime> Dt_SentToCustomer { get; set; }
    public Nullable<System.DateTime> Dt_ProposalDeadline { get; set; }
    public Nullable<System.DateTime> Dt_Proposal_Is_Submitted_To_Customer { get; set; }
    public Nullable<System.DateTime> Dt_FO_Is_Submitted_To_Customer { get; set; }
    public Nullable<bool> Proximity { get; set; }
    public string Other_Expertise_Required { get; set; }
    public Nullable<System.DateTime> Expected_Project_Start_Date { get; set; }
    public Nullable<double> TOTAL_man_days { get; set; }

    public string Final_Candidate { get; set; }

    public string Specific_Contract_Number { get; set; }
    public Nullable<System.DateTime> Dt_SC_Is_Received { get; set; }
    public Nullable<System.DateTime> Dt_SC_Is_signed { get; set; }
    public Nullable<System.DateTime> Droject_Start_Date { get; set; }
    public Nullable<System.DateTime> Max_End_Date { get; set; }
    public Nullable<System.DateTime> Ext_Max_End_Date { get; set; }
    public Nullable<System.DateTime> Max_End_DateSC { get; set; }

    public Nullable<double> Number_Of_Days { get; set; }
    public string Bank_Account { get; set; }
    public Nullable<System.DateTime> Validity_Date { get; set; }
    public Nullable<double> Daily_Price { get; set; }
    public Nullable<double> Total_Price { get; set; }
    public string LoginCreation { get; set; }
    public Nullable<System.DateTime> DateCreation { get; set; }
    public string LoginUpdate { get; set; }
    public Nullable<System.DateTime> DateUpdate { get; set; }
    public Nullable<System.DateTime> Dt_FO_Deadline { get; set; }
    public string TechnicalContact { get; set; }
    public string LinkedBR { get; set; }
    public virtual Company Company { get; set; }
    public virtual Category Category { get; set; }
    public virtual Level Level { get; set; }
    public virtual PlaceOfDelivery PlaceOfDelivery { get; set; }
    public virtual StatusBr StatusBR { get; set; }
    public virtual BrType TypeBR { get; set; }
    public virtual Model.Type Type { get; set; }
    public virtual TypeOfContract TypeOfContract { get; set; }
    public virtual Profile Profile { get; set; }
    public virtual BrSource BRSource { get; set; }
    public virtual RequestFormStatus RequestFormStatus { get; set; }
    public string Comment { get; set; }

    public Nullable<double> AdditionalBudget { get; set; }
    public Nullable<double> Penalty { get; set; }
    public string PenaltyComment { get; set; }

    public string OpenIntendedComment { get; set; }
    public IEnumerable<Object> consultantData { get; set; }

    public TypeOfCost Cost { get; set; }
    public TypeOfContractSc TypeOfContractSC { get; set; }
    public string SpecificClientCode { get; set; }
    public string ResponseMessage { get; set; }
    public Nullable<System.DateTime> Dt_ChangeOffer { get; set; }
    public Nullable<System.DateTime> Dt_ChangeOffer_Is_Submitted_To_Customer { get; set; }
    public Nullable<double> ConsultantCost { get; set; }
    public double MFRate { get; set; }
    public bool IsCascade { get; set; }
    public Nullable<double> MFMaxAmount { get; set; }
    public Nullable<double> PenaltyDays { get; set; }
    public bool SCExist { get; set; }
    public bool HasTransfer { get; set; }
    public Company LeadingCompany { get; set; }

    public Nullable<double> PTMOwnerRate { get; set; }
    public Nullable<System.DateTime> Dt_Acceptance { get; set; }
    public Nullable<System.DateTime> Dt_Refusal { get; set; }

    public IEnumerable<Object> SubcontractorData { get; set; }

    public Nullable<System.DateTime> dt_AcknowledgementDeadline { get; set; }

    public string GeneralComment { get; set; }
    public int? AdditionalBudget_idCurrency { get; set; }
    public Nullable<double> SubtotalPrice { get; set; }
    public Nullable<double> GeneralBudget { get; set; }
    public CurrencyRateParam CurrencySalesPrice { get; set; }
    public CurrencyRateParam CurrencyAdditionalBudget { get; set; }
    public int IdSC { get; set; }
    public int? Id_Service_Level_Category { get; set; }
    public Nullable<System.DateTime> Dt_ReceptionDraft { get; set; }
    public Nullable<bool> Draft_Approval { get; set; }
    public string Draft_ContractApprover { get; set; }
    public Nullable<System.DateTime> Dt_DraftApproval { get; set; }

}
