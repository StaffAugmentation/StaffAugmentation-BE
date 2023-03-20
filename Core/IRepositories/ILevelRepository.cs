using Core.ViewModel;

namespace Core.IRepositories
{
    public interface ILevelRepository
    {
        Task<List<LevelViewModel>?> GetLevel();
        Task<LevelViewModel?> GetLevel(int Id);
        Task<LevelViewModel?> CreateLevel(LevelViewModel level);
        Task<LevelViewModel?> UpdateLevel(LevelViewModel level);
        Task<List<LevelViewModel>?> DeleteLevel(int Id);
    }
}
