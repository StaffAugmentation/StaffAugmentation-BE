using Core.Model;
using Core.ViewModel;

namespace Core.IRepositories;

public interface IDepartmentRepository : IGenericRepository<DepartmentViewModel, Level, int>
{
}
