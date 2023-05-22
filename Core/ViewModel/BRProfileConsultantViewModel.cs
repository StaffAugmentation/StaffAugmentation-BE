using Core.Model;

namespace Core.ViewModel;
public class BRProfileConsultantViewModel
{
    public int Id { get; set; }
    public double? ConsCostMargin { get; set; }
    public double? ThirdPartyrate { get; set; }
    public int ConsCostIdCurrency { get; set; }
    public int TPRateIdCurrency { get; set; }
    public double? AgreedRate { get; set; }
    public int? IdBRProfile { get; set; }
    public int IdProfileTemp { get; set; }
    public DateTime? ExpectedStartDate { get; set; }
    public TypeOfContractSC TypeOfContractSC { get; set; }
    public SubContractor SubContractor { get; set; }
    public int? IdPTMOwner { get; set; }
    public string PTMOwnerAdress { get; set; }
    public double? PTMOwnerRate { get; set; }
    public string IdTypeInvolvement { get; set; }
    public double? NbrDays { get; set; }
    public double? TotalPriceMargin { get; set; }
    public double? TotalCost { get; set; }
    public double? NbrDaysCons { get; set; }
    public int PTMOwnerRateidCurrency { get; set; }
    public int TotalCostidCurrency { get; set; }
    public bool IsDeleted { get; set; }
    public double? DaysOfTraining { get; set; }
}
