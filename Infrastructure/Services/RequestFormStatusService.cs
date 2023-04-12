using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services
{
    public class RequestFormStatusService : IRequestFormStatusService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RequestFormStatusService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<RequestFormStatusViewModel>?> GetRequestFormStatus()
        {
            return await _unitOfWork.RequestFormStatus.GetAll();
        }

        public async Task<RequestFormStatusViewModel?> GetRequestFormStatus(string Id)
        {
            return await _unitOfWork.RequestFormStatus.Find(entity => entity.Id == Id);
        }

        public async Task<RequestFormStatusViewModel?> CreateRequestFormStatus(RequestFormStatusViewModel RequestFormStatus)
        {
            return await _unitOfWork.RequestFormStatus.Create(RequestFormStatus);
        }

        public async Task<RequestFormStatusViewModel?> UpdateRequestFormStatus(RequestFormStatusViewModel RequestFormStatus)
        {
            return await _unitOfWork.RequestFormStatus.Update(RequestFormStatus.Id, RequestFormStatus);
        }

        public async Task<IEnumerable<RequestFormStatusViewModel>?> DeleteRequestFormStatus(string Id)
        {
            return await _unitOfWork.RequestFormStatus.Delete(Id);
        }

    }
}
