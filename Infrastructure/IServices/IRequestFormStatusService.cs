using Core.ViewModel;

namespace Business.IServices;

public interface IRequestFormStatusService
{
    Task<IEnumerable<RequestFormStatusViewModel>?> GetRequestFormStatus();
    Task<RequestFormStatusViewModel?> GetRequestFormStatus(string Id);
    Task<RequestFormStatusViewModel?> CreateRequestFormStatus(RequestFormStatusViewModel RequestFormStatus);
    Task<RequestFormStatusViewModel?> UpdateRequestFormStatus(RequestFormStatusViewModel RequestFormStatus);
    Task<IEnumerable<RequestFormStatusViewModel>?> DeleteRequestFormStatus(string Id);
}
