using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services
{
    public class RequestFormStatusService : IRequestFormStatusService
    {
        private readonly IRequestFormStatusRepository repo;
        public RequestFormStatusService(IRequestFormStatusRepository RequestFormStatusrepository)
        {
            repo = RequestFormStatusrepository;
        }

        public async Task<List<RequestFormStatusViewModel>?> GetRequestFormStatus()
        {
            return await repo.GetRequestFormStatus();
        }

        public async Task<RequestFormStatusViewModel?> GetRequestFormStatus(int Id)
        {
            return await repo.GetRequestFormStatus(Id);
        }

        public async Task<RequestFormStatusViewModel?> CreateRequestFormStatus(RequestFormStatusViewModel RequestFormStatus)
        {
            return await repo.CreateRequestFormStatus(RequestFormStatus);
        }

        public async Task<RequestFormStatusViewModel?> UpdateRequestFormStatus(RequestFormStatusViewModel RequestFormStatus)
        {
            return await repo.UpdateRequestFormStatus(RequestFormStatus);
        }

        public async Task<List<RequestFormStatusViewModel>?> DeleteRequestFormStatus(int Id)
        {
            return await repo.DeleteRequestFormStatus(Id);
        }

    }
}
