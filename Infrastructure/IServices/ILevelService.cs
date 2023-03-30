using Core.ViewModel;

namespace Business.IServices;

public interface ILevelService
{
    Task<IEnumerable<LevelViewModel>?> GetLevel();
    Task<LevelViewModel?> GetLevel(int Id);
    Task<LevelViewModel?> CreateLevel(LevelViewModel level);
    Task<LevelViewModel?> UpdateLevel(LevelViewModel level);
    Task<IEnumerable<LevelViewModel>?> DeleteLevel(int Id);
}