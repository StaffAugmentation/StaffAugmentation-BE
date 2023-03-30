using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services
{
    public class HighestDegreeService : IHighestDegreeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public HighestDegreeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<HighestDegreeViewModel>?> GetHighestDegree()
        {
            return await _unitOfWork.HighestDegree.GetAll();
        }

        public async Task<HighestDegreeViewModel?> GetHighestDegree(int Id)
        {
            return await _unitOfWork.HighestDegree.Find(entity => entity.Id == Id);
        }

        public async Task<HighestDegreeViewModel?> CreateHighestDegree(HighestDegreeViewModel HighestDegree)
        {
            return await _unitOfWork.HighestDegree.Create(HighestDegree);
        }

        public async Task<HighestDegreeViewModel?> UpdateHighestDegree(HighestDegreeViewModel HighestDegree)
        {
            return await _unitOfWork.HighestDegree.Update(HighestDegree.Id, HighestDegree);
        }

        public async Task<IEnumerable<HighestDegreeViewModel>?> DeleteHighestDegree(int Id)
        {
            return await _unitOfWork.HighestDegree.Delete(Id);
        }

    }
}
