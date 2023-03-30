using Core.ViewModel;

namespace Core.IRepositories;

public interface ITypeRepository : IGenericRepository<TypeViewModel, Core.Model.Type, int>
{
}
