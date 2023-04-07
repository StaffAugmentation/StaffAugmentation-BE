using Core.ViewModel;

namespace Business.IServices;

public interface IForecastService
{
    Task<IEnumerable<ForecastViewModel>?> GetForecastByYear(int year);
    Task<ForecastViewModel?> UpdateForecast(ForecastViewModel Forecast);
}
