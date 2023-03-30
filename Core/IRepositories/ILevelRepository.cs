using Core.Model;
using Core.ViewModel;

namespace Core.IRepositories;

public interface ILevelRepository : IGenericRepository<LevelViewModel, Level, int>
{
}
