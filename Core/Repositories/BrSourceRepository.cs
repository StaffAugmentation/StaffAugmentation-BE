using AutoMapper;
using Core.Data;
using Core.Model;
using Core.ViewModel;
using Core.IRepositories;

namespace Core.Repositories;

public class BrSourceRepository : GenericRepository<BrSourceViewModel, BrSource, string>, IBrSourceRepository
{
    public BrSourceRepository(DataContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
