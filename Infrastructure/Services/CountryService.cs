using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services
{
    public class CountryService : ICountryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CountryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<CountryViewModel>?> GetCountry()
        {
            return await _unitOfWork.Country.GetAll();
        }

        public async Task<CountryViewModel?> GetCountry(int Id)
        {
            return await _unitOfWork.Country.Find(entity => entity.Id == Id);
        }

        public async Task<CountryViewModel?> CreateCountry(CountryViewModel country)
        {
            return await _unitOfWork.Country.Create(country);
        }

        public async Task<CountryViewModel?> UpdateCountry(CountryViewModel country)
        {
            return await _unitOfWork.Country.Update(country.Id, country);
        }

        public async Task<IEnumerable<CountryViewModel>?> DeleteCountry(int Id)
        {
            return await _unitOfWork.Country.Delete(Id);
        }

    }
}
