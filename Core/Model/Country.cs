using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("Countries")]
public class Country
{
    public int Id { get; set; }

    public string CountryName { get; set; } = null!;

    public bool IsVisible { get; set; }

    [Column("Hotel_Ceiling")]
    public double? HotelCeiling { get; set; }

    [Column("Daily_Allowance")]
    public double? DailyAllowance { get; set; }
}