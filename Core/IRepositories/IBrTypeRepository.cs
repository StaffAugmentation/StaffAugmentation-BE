using Core.ViewModel;

namespace Core.IRepositories
{
    public interface IBrTypeRepository
    {
        Task<List<BrTypeViewModel>?> GetBrType();
        Task<BrTypeViewModel?> GetBrType(int Id);
        Task<BrTypeViewModel?> CreateBrType(BrTypeViewModel brType);
        Task<BrTypeViewModel?> UpdateBrType(BrTypeViewModel brType);
        Task<List<BrTypeViewModel>?> DeleteBrType(int Id);
    }
}
