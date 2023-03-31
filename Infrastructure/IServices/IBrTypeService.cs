using Core.ViewModel;

namespace Business.IServices;

public interface IBrTypeService
{
    Task<IEnumerable<BrTypeViewModel>?> GetBrType();
    Task<BrTypeViewModel?> GetBrType(int Id);
    Task<BrTypeViewModel?> CreateBrType(BrTypeViewModel brType);
    Task<BrTypeViewModel?> UpdateBrType(BrTypeViewModel brType);
    Task<IEnumerable<BrTypeViewModel>?> DeleteBrType(int Id);
}
