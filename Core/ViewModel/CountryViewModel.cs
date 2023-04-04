namespace Core.ViewModel;
public class CountryViewModel
{
    public int Id { get; set; }

    public string CountryName { get; set; } = null!;

    public bool IsVisible { get; set; }

    public double? HotelCeiling { get; set; }

    public double? DailyAllowance { get; set; }
}