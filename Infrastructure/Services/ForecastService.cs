using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services
{
    public class ForecastService : IForecastService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ForecastService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<ForecastViewModel>?> GetForecastByYear(int year)
        {
            return await _unitOfWork.Forecast.GetAll(null,Forecast => Forecast.Year == year,"ASC",Forecast => Forecast.Month);
        }

        public async Task<ForecastViewModel?> UpdateForecast(ForecastViewModel Forecast)
        {
            return await _unitOfWork.Forecast.Update(Forecast.Id, Forecast);
        }


    }
}
