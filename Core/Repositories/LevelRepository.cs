using AutoMapper;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

public class LevelRepository : GenericRepository<LevelViewModel, Level, int>, ILevelRepository
{
    public LevelRepository(DataContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
