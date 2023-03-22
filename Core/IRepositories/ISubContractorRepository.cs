using Core.ViewModel;

namespace Core.IRepositories
{
    public interface ISubContractorRepository
    {
        Task<List<SubContractorViewModel>?> GetSubContractor();
        Task<SubContractorViewModel?> GetSubContractor(int Id);
        Task<SubContractorViewModel?> CreateSubContractor(SubContractorViewModel subContractor);
        Task<SubContractorViewModel?> UpdateSubContractor(SubContractorViewModel subContractor);
        Task<List<SubContractorViewModel>?> DeleteSubContractor(int Id);
    }
}
