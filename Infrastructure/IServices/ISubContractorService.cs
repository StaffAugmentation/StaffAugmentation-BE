using Core.ViewModel;

namespace Business.IServices;

public interface ISubContractorService
{
    Task<IEnumerable<SubContractorViewModel>?> GetSubContractor();
    Task<SubContractorViewModel?> GetSubContractor(int Id);
    Task<SubContractorViewModel?> CreateSubContractor(SubContractorViewModel subContractor);
    Task<SubContractorViewModel?> UpdateSubContractor(SubContractorViewModel subContractor);
    Task<IEnumerable<SubContractorViewModel>?> DeleteSubContractor(int Id);
}