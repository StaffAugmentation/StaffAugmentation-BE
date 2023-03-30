using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services
{
    public class BrSourceService : IBrSourceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BrSourceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<BrSourceViewModel>?> GetBrSource()
        {
            return await _unitOfWork.BrSource.GetAll();
        }

        public async Task<BrSourceViewModel?> GetBrSource(string IdSource)
        {
            return await _unitOfWork.BrSource.Find(entity => entity.Id == IdSource);
        }

        public async Task<BrSourceViewModel?> CreateBrSource(BrSourceViewModel brSource)
        {
            return await _unitOfWork.BrSource.Create(brSource);
        }

        public async Task<BrSourceViewModel?> UpdateBrSource(BrSourceViewModel brSource)
        {
            return await _unitOfWork.BrSource.Update(brSource.Id, brSource);
        }

        public async Task<IEnumerable<BrSourceViewModel>?> DeleteBrSource(string IdSource)
        {
            return await _unitOfWork.BrSource.Delete(IdSource);
        }
    }
}
