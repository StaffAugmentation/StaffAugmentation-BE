using Core.ViewModel;

namespace Business.IServices
{
    public interface IBrSourceService
    {
        Task<List<BrSourceViewModel>?> GetBrSource();
        Task<BrSourceViewModel?> GetBrSource(string IdSource);
        Task<BrSourceViewModel?> CreateBrSource(BrSourceViewModel brSource);
        Task<BrSourceViewModel?> UpdateBrSource(BrSourceViewModel brSource);
        Task<List<BrSourceViewModel>?> DeleteBrSource(string IdSource);
    }
}
