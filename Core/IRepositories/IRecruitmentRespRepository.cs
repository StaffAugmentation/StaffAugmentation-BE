using Core.ViewModel;

namespace Core.IRepositories
{
    public interface IRecruitmentRespRepository
    {
        Task<List<RecruitmentRespViewModel>?> GetRecruitmentResp();
        Task<RecruitmentRespViewModel?> GetRecruitmentResp(int Id);
        Task<RecruitmentRespViewModel?> CreateRecruitmentResp(RecruitmentRespViewModel recruitmentResp);
        Task<RecruitmentRespViewModel?> UpdateRecruitmentResp(RecruitmentRespViewModel recruitmentResp);
        Task<List<RecruitmentRespViewModel>?> DeleteRecruitmentResp(int Id);
    }
}
