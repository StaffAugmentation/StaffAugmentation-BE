using AutoMapper;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

public class CountryRepository : GenericRepository<CountryViewModel, Country, int>, ICountryRepository
{
    public CountryRepository(DataContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
