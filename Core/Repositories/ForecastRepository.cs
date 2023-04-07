using AutoMapper;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

public class ForecastRepository : GenericRepository<ForecastViewModel, Forecast, int>, IForecastRepository
{
    public ForecastRepository(DataContext context, IMapper mapper) : base(context, mapper)
    { }
}
