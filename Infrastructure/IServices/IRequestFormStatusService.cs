using Core.ViewModel;

namespace Business.IServices
{
    public interface IRequestFormStatusService
    {
        Task<List<RequestFormStatusViewModel>?> GetRequestFormStatus();
        Task<RequestFormStatusViewModel?> GetRequestFormStatus(string Id);
        Task<RequestFormStatusViewModel?> CreateRequestFormStatus(RequestFormStatusViewModel RequestFormStatus);
        Task<RequestFormStatusViewModel?> UpdateRequestFormStatus(RequestFormStatusViewModel RequestFormStatus);
        Task<List<RequestFormStatusViewModel>?> DeleteRequestFormStatus(string Id);
    }
}
