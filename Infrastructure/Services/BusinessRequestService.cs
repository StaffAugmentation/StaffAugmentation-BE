using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services;

public class BusinessRequestService : IBusinessRequestService
{
    private readonly IUnitOfWork _unitOfWork;

    public BusinessRequestService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<BusinessRequestViewModel>?> GetBusinessRequests()
    {
        return await _unitOfWork.BusinessRequest.GetAll();
    }

    public async Task<BusinessRequestViewModel?> GetBusinessRequest(int Id)
    {
        return await _unitOfWork.BusinessRequest.Find(entity => entity.Id == Id);
    }

    public async Task<BusinessRequestViewModel?> CreateBusinessRequest(BusinessRequestViewModel br)
    {
        return await _unitOfWork.BusinessRequest.Create(br);
    }

    public async Task<BusinessRequestViewModel?> UpdateBusinessRequest(BusinessRequestViewModel br)
    {
        return await _unitOfWork.BusinessRequest.Update(br.Id, br);
    }

    public async Task<IEnumerable<BusinessRequestViewModel>?> DeleteBusinessRequest(int Id)
    {
        return await _unitOfWork.BusinessRequest.Delete(Id);
    }
}
