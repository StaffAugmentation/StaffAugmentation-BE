using Core.Model;
using Core.ViewModel;

namespace Business.IServices;

public interface IBusinessRequestService
{
    Task<IEnumerable<object>?> GetBusinessRequests(int UserId, AdvancedSearchViewModel Search, int LocalUTC);
    Task<BusinessRequestViewModel?> GetBusinessRequest(int Id, int LocalUTC);
    Task<AddResultViewModel?> AddBusinessRequest(BusinessRequest BR, string Login, List<ProfileLevelViewModel> Listprofiles, List<BrConsultantViewModel> ListConsultants, List<CandidateDataViewModel> ListCandidates, List<BRAttachmentViewModel> ListAttachments, List<BrSubcontractorViewModel> ListBRSubcontractor);
    Task<BusinessRequestViewModel?> UpdateBusinessRequest(BusinessRequestViewModel BR);
    Task<IEnumerable<BusinessRequestViewModel>?> DeleteBusinessRequest(int Id);
}
