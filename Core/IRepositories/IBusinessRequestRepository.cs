using Core.Model;
using Core.ViewModel;

namespace Core.IRepositories;

public interface IBusinessRequestRepository
{
    Task<List<object>?> GetBusinessRequests(int UserId, AdvancedSearchViewModel Search, int LocalUTC);
    Task<BusinessRequestViewModel?> GetBusinessRequest(int Id, int LocalUTC);
    Task<AddResultViewModel?> AddBusinessRequest(BusinessRequest Br, string Login, List<ProfileLevelViewModel> Listprofiles, List<BrConsultantViewModel> ListConsultants, List<CandidateDataViewModel> ListCandidates, List<BRAttachmentViewModel> ListAttachments, List<BrSubcontractorViewModel> ListBRSubcontractor);
}
