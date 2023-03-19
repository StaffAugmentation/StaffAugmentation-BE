using Business.IServices;
using Core.IRepositories;
using Core.Model;
using Core.ViewModel;

namespace Business.Services
{
    public class LevelService : ILevelService
    {
        private readonly ILevelRepository repo;
        public LevelService(ILevelRepository LevelRepository)
        {
            repo = LevelRepository;
        }

        public async Task<List<LevelViewModel>?> GetLevel()
        {
            return await repo.GetLevel();
        }

        public async Task<LevelViewModel?> GetLevel(int Id)
        {
            return await repo.GetLevel(Id);
        }

        public async Task<LevelViewModel?> CreateLevel(LevelViewModel level)
        {
            return await repo.CreateLevel(level);
        }

        public async Task<LevelViewModel?> UpdateLevel(LevelViewModel level)
        {
            return await repo.UpdateLevel(level);
        }

        public async Task<List<LevelViewModel>?> DeleteLevel(int Id)
        {
            return await repo.DeleteLevel(Id);
        }

    }
}
