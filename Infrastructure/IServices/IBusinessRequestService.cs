using Core.ViewModel;

namespace Business.IServices;

public interface IBusinessRequestService
{
    Task<IEnumerable<BusinessRequestViewModel>?> GetBusinessRequests();
    Task<BusinessRequestViewModel?> GetBusinessRequest(int Id);
    Task<BusinessRequestViewModel?> CreateBusinessRequest(BusinessRequestViewModel BR);
    Task<BusinessRequestViewModel?> UpdateBusinessRequest(BusinessRequestViewModel BR);
    Task<IEnumerable<BusinessRequestViewModel>?> DeleteBusinessRequest(int Id);
}
