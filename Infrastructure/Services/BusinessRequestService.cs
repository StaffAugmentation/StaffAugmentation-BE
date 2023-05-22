using Business.IServices;
using Core.IRepositories;
using Core.Model;
using Core.ViewModel;

namespace Business.Services;

public class BusinessRequestService : IBusinessRequestService
{
    private readonly IUnitOfWork _unitOfWork;

    public BusinessRequestService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<object>?> GetBusinessRequests(int UserId, AdvancedSearchViewModel Search, int LocalUTC)
    {
        return await _unitOfWork.BusinessRequest.GetBusinessRequests(UserId, Search, LocalUTC);
    }

    public async Task<BusinessRequestViewModel?> GetBusinessRequest(int Id, int LocalUTC)
    {
        return await _unitOfWork.BusinessRequest.GetBusinessRequest(Id,LocalUTC);
    }

    public async Task<AddResultViewModel?> AddBusinessRequest(BusinessRequest br, string Login, List<ProfileLevelViewModel> Listprofiles, List<BrConsultantViewModel> ListConsultants, List<CandidateDataViewModel> ListCandidates, List<BRAttachmentViewModel> ListAttachments, List<BrSubcontractorViewModel> ListBRSubcontractor)
    {
        return await _unitOfWork.BusinessRequest.AddBusinessRequest(br, Login, Listprofiles, ListConsultants, ListCandidates, ListAttachments, ListBRSubcontractor);
    }

    public async Task<BusinessRequestViewModel?> UpdateBusinessRequest(BusinessRequestViewModel br)
    {
        return null;
        //return await _unitOfWork.BusinessRequest.Update(br.Id, br);
    }

    public async Task<IEnumerable<BusinessRequestViewModel>?> DeleteBusinessRequest(int Id)
    {
        return null;
        //return await _unitOfWork.BusinessRequest.Delete(Id);
    }
}
