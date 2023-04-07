using Core.Model;
using Core.ViewModel;

namespace Core.IRepositories;

public interface IForecastRepository : IGenericRepository<ForecastViewModel, Forecast, int>
{
}
