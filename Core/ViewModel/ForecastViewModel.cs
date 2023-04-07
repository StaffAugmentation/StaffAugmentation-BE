using System.ComponentModel.DataAnnotations.Schema;

namespace Core.ViewModel;

public class ForecastViewModel
{
    public int Id { get; set; }

    public int Year { get; set; }

    public int Month { get; set; }

    public double WorkingDays { get; set; }

    public double AbsenteeismDays { get; set; }

    public double ForecastedDays { get; set; }  

}

