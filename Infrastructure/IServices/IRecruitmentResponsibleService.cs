using Core.ViewModel;

namespace Business.IServices;

public interface IRecruitmentResponsibleService
{
    Task<IEnumerable<RecruitmentResponsibleViewModel>?> GetRecruitmentResponsible();
    Task<RecruitmentResponsibleViewModel?> GetRecruitmentResponsible(int Id);
    Task<RecruitmentResponsibleViewModel?> CreateRecruitmentResponsible(RecruitmentResponsibleViewModel recruitmentResp);
    Task<RecruitmentResponsibleViewModel?> UpdateRecruitmentResponsible(RecruitmentResponsibleViewModel recruitmentResp);
    Task<IEnumerable<RecruitmentResponsibleViewModel>?> DeleteRecruitmentResponsible(int Id);
}