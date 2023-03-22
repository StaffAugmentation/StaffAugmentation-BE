using Core.ViewModel;

namespace Core.IRepositories
{
    public interface ITypeRepository
    {
        Task<List<TypeViewModel>?> GetType();
        Task<TypeViewModel?> GetType(int Id);
        Task<TypeViewModel?> CreateType(TypeViewModel type);
        Task<TypeViewModel?> UpdateType(TypeViewModel type);
        Task<List<TypeViewModel>?> DeleteType(int Id);


    }
}
