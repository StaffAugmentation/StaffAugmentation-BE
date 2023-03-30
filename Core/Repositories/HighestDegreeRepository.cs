using AutoMapper;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

public class HighestDegreeRepository : GenericRepository<HighestDegreeViewModel, HighestDegree, int>, IHighestDegreeRepository
{
    public HighestDegreeRepository(DataContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
