using Core.ViewModel;

namespace Business.IServices;

public interface ICountryService
{
    Task<IEnumerable<CountryViewModel>?> GetCountry();
    Task<CountryViewModel?> GetCountry(int Id);
    Task<CountryViewModel?> CreateCountry(CountryViewModel country);
    Task<CountryViewModel?> UpdateCountry(CountryViewModel country);
    Task<IEnumerable<CountryViewModel>?> DeleteCountry(int Id);
}