namespace Core.ViewModel;

public class AppParameterViewModel
{
    public int Id { get; set; }
    public bool? QTMDailyPriceIsActive { get; set; }
    public bool? TMDailyPriceIsActive { get; set; }
    public int? DaysBeforeDeletingFile { get; set; }
    public string? SAUrlAppProd { get; set; }
    public string? SAEmail { get; set; }
    public int? BrAdvancedSearchDate { get; set; }
    public int? SCAdvancedSearchPeriod { get; set; }
    public string? HREmailSubject { get; set; }
    public string? HREmailText { get; set; }
    public string? ConsultantEmailSubject { get; set; }
    public string? ConsultantEmailText { get; set; }
    public string? SAVersion { get; set; }
    public bool? UseLDAPService { get; set; }
    public string? ContractApprover { get; set; }
    public string? ContractApproverEmail { get; set; }
}