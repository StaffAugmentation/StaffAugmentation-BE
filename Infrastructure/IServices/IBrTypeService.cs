using Core.ViewModel;

namespace Business.IServices
{
    public interface IBrTypeService
    {
        Task<List<BrTypeViewModel>?> GetBrType();
        Task<BrTypeViewModel?> GetBrType(int Id);
        Task<BrTypeViewModel?> CreateBrType(BrTypeViewModel brType);
        Task<BrTypeViewModel?> UpdateBrType(BrTypeViewModel brType);
        Task<List<BrTypeViewModel>?> DeleteBrType(int Id);
    }
}
