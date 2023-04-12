using Core.ViewModel;

namespace Business.IServices;

public interface IBrSourceService
{
    Task<IEnumerable<BrSourceViewModel>?> GetBrSource();
    Task<BrSourceViewModel?> GetBrSource(string IdSource);
    Task<BrSourceViewModel?> CreateBrSource(BrSourceViewModel brSource);
    Task<BrSourceViewModel?> UpdateBrSource(BrSourceViewModel brSource);
    Task<IEnumerable<BrSourceViewModel>?> DeleteBrSource(string IdSource);
}
