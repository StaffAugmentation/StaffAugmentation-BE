using Core.Model;
using Core.ViewModel;

namespace Core.IRepositories;

public interface ICategoryRepository : IGenericRepository<CategoryViewModel, Category, int>
{
}
