namespace Core.ViewModel;
public class BrSubcontractorViewModel
{
    public int Id { get; set; }
    public int IdSubcontractor { get; set; }
    public string IdTypeInvolvement { get; set; }
    public double? Nbr_Days { get; set; }
    public double? Cost { get; set; }
    public double? Margin { get; set; }
    public double TotalCost { get; set; }
    public int TotalCostIdCurrency { get; set; }

}
