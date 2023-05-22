using Core.Model;

namespace Core.ViewModel;
public class BrConsultantViewModel
{
    public int Id { get; set; }
    public string FrameworkContract { get; set; }
    public string RequestReference { get; set; }
    public int? TypeOfContractId { get; set; }
    public double? AgreedRate { get; set; }
    public string Comment { get; set; }
    public DateTime? ExpectedStartDate { get; set; }
    public string SubcontractorName { get; set; }
    public int BRId { get; set; }
    public int ConsultantId { get; set; }
    public int? CandidateId { get; set; }
    public double? ConsCostMargin { get; set; }
    public double? ThirdPartyRate { get; set; }
    public int? SubcontractorId { get; set; }
    public int? IdPTMOwner { get; set; }
    public string PTMOwnerAdress { get; set; }
    public double? PTMOwnerRate { get; set; }
    public string IdTypeInvolvement { get; set; }
    public double? NbrDays { get; set; }
    public double? TotalPriceMargin { get; set; }
    public double? TotalCost { get; set; }
    public int? IdBRProfile { get; set; }
    public int IdProfileTemp { get; set; }
    public double? NbrDaysCons { get; set; }
    public virtual TypeOfContractSC TypeOfContractSC { get; set; }
    public virtual SubContractor SubContractor { get; set; }
    public virtual Consultant Consultant { get; set; }
    public virtual bool IsChanged { get; set; }
    public int ConsCostIdCurrency { get; set; }
    public int TPRateIdCurrency { get; set; }
    public int PTMOwnerRateIdCurrency { get; set; }
    public int TotalCostIdCurrency { get; set; }
    public string OERPEmployeeNumber { get; set; }
    public List<BRProfileConsultantViewModel> BRProfile { get; set; }
}
