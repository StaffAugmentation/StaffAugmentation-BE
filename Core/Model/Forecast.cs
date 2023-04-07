using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("ForecastsParams")]
public partial class Forecast
{
    public int Id { get; set; }

    [Column("YearF")]
    public int Year { get; set; }

    [Column("MonthF")]
    public int Month { get; set; }

    public double WorkingDays { get; set; }

    public double AbsenteeismDays { get; set; }

    public double ForecastedDays { get; set; }

}