using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services
{
    public class SubContractorService : ISubContractorService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SubContractorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<SubContractorViewModel>?> GetSubContractor()
        {
            return await _unitOfWork.SubContractor.GetAll();
        }

        public async Task<SubContractorViewModel?> GetSubContractor(int Id)
        {
            return await _unitOfWork.SubContractor.Find(entity => entity.Id == Id);
        }

        public async Task<SubContractorViewModel?> CreateSubContractor(SubContractorViewModel subContractor)
        {
            return await _unitOfWork.SubContractor.Create(subContractor);
        }

        public async Task<SubContractorViewModel?> UpdateSubContractor(SubContractorViewModel subContractor)
        {
            return await _unitOfWork.SubContractor.Update(subContractor.Id, subContractor);
        }

        public async Task<IEnumerable<SubContractorViewModel>?> DeleteSubContractor(int Id)
        {
            return await _unitOfWork.SubContractor.Delete(Id);
        }

    }
}
