namespace Core.ViewModel;

public class CalculatedTMFieldsViewModel
{
    public double? ManagementFee { get; set; }
    public double? DailyMargin { get; set; }
    public double? RemainingDays { get; set; }
    public string? ContractStatus { get; set; }
    public string? MessageExceedLimit { get; set; }
    public string? ConsultantName { get; set; }

    public List<SCDaysWorkedByMonthViewModel>? ListDW { get; set; }
}
