namespace Core.ViewModel;

public class AdvancedSearchViewModel
{
    public string? RequestNumber { get; set; }
    public DateTime? AdvancedSearchDate { get; set; }
    public List<string>? AdvancedSearchList { get; set; }
    public List<string>? AdvancedSearchListFWC { get; set; }
    public DateTime? PaymentSchedule { get; set; }
}
