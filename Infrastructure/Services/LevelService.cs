using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services
{
    public class LevelService : ILevelService
    {
        private readonly IUnitOfWork _unitOfWork;

        public LevelService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<LevelViewModel>?> GetLevel()
        {
            return await _unitOfWork.Level.GetAll();
        }

        public async Task<LevelViewModel?> GetLevel(int Id)
        {
            return await _unitOfWork.Level.Find(level => level.Id == Id);
        }

        public async Task<LevelViewModel?> CreateLevel(LevelViewModel level)
        {
            return await _unitOfWork.Level.Create(level);
        }

        public async Task<LevelViewModel?> UpdateLevel(LevelViewModel level)
        {
            return await _unitOfWork.Level.Update(level.Id, level);
        }

        public async Task<IEnumerable<LevelViewModel>?> DeleteLevel(int Id)
        {
            return await _unitOfWork.Level.Delete(Id);
        }

    }
}
