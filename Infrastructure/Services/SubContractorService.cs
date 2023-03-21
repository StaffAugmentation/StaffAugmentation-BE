using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services
{
    public class SubContractorService : ISubContractorService
    {
        private readonly ISubContractorRepository repo;
        public SubContractorService(ISubContractorRepository SubContractorRepository)
        {
            repo = SubContractorRepository;
        }

        public async Task<List<SubContractorViewModel>?> GetSubContractor()
        {
            return await repo.GetSubContractor();
        }

        public async Task<SubContractorViewModel?> GetSubContractor(int Id)
        {
            return await repo.GetSubContractor(Id);
        }

        public async Task<SubContractorViewModel?> CreateSubContractor(SubContractorViewModel subContractor)
        {
            return await repo.CreateSubContractor(subContractor);
        }

        public async Task<SubContractorViewModel?> UpdateSubContractor(SubContractorViewModel subContractor)
        {
            return await repo.UpdateSubContractor(subContractor);
        }

        public async Task<List<SubContractorViewModel>?> DeleteSubContractor(int Id)
        {
            return await repo.DeleteSubContractor(Id);
        }

    }
}
