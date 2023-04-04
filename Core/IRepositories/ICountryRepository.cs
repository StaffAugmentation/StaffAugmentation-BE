using Core.Model;
using Core.ViewModel;

namespace Core.IRepositories;

public interface ICountryRepository : IGenericRepository<CountryViewModel, Country, int>
{
}
