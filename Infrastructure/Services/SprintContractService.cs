using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services
{
    public class SprintContractService : ISprintContractService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SprintContractService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<object>?> GetSprintContracts()
        {
            return await _unitOfWork.SprintContract.GetAll();
        }

        public async Task<SprintContractViewModel?> GetSprintContract(int Id)
        {
            return null;
            //return await _unitOfWork.SprintContract.Find(entity => entity.Id == Id);
        }

        public async Task<SprintContractViewModel?> CreateSprintContract(SprintContractViewModel sc)
        {
            return null;
            //return await _unitOfWork.SprintContract.Create(sc);
        }

        public async Task<SprintContractViewModel?> UpdateSprintContract(SprintContractViewModel sc)
        {
            return null;
            //return await _unitOfWork.SprintContract.Update(sc.Id, sc);
        }

        public async Task<IEnumerable<SprintContractViewModel>?> DeleteSprintContract(int Id)
        {
            return null;
            //return await _unitOfWork.SprintContract.Delete(Id);
        }
    }
}