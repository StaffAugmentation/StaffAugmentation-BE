using Core.ViewModel;

namespace Business.IServices;

public interface IRecruitmentResponsibleService
{
    Task<List<RecruitmentResponsibleViewModel>?> GetRecruitmentResponsible();
    Task<RecruitmentResponsibleViewModel?> GetRecruitmentResponsible(int Id);
    Task<RecruitmentResponsibleViewModel?> CreateRecruitmentResponsible(RecruitmentResponsibleViewModel recruitmentResp);
    Task<RecruitmentResponsibleViewModel?> UpdateRecruitmentResponsible(RecruitmentResponsibleViewModel recruitmentResp);
    Task<List<RecruitmentResponsibleViewModel>?> DeleteRecruitmentResponsible(int Id);
}