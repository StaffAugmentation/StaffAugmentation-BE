using Core.ViewModel;

namespace Core.IRepositories
{
    public interface IBrSourceRepository
    {
        Task<List<BrSourceViewModel>?> GetBrSource();
        Task<BrSourceViewModel?> GetBrSource(string IdSource);
        Task<BrSourceViewModel?> CreateBrSource(BrSourceViewModel brSource);
        Task<BrSourceViewModel?> UpdateBrSource(BrSourceViewModel brSource);
        Task<List<BrSourceViewModel>?> DeleteBrSource(string IdSource);
    }
}
