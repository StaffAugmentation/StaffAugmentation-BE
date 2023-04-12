using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories
{
    public class AppParameterRepository : GenericRepository<AppParameterViewModel, AppParameter, int>, IAppParameterRepository
    {
        public AppParameterRepository(DataContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
