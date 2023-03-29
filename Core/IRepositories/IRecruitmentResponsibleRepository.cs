using Core.ViewModel;

namespace Core.IRepositories
{
    public interface IRecruitmentResponsibleRepository
    {
        Task<List<RecruitmentResponsibleViewModel>?> GetRecruitmentResponsible();
        Task<RecruitmentResponsibleViewModel?> GetRecruitmentResponsible(int Id);
        Task<RecruitmentResponsibleViewModel?> CreateRecruitmentResponsible(RecruitmentResponsibleViewModel recruitmentResponsibleVM);
        Task<RecruitmentResponsibleViewModel?> UpdateRecruitmentResponsible(RecruitmentResponsibleViewModel recruitmentResponsibleVM);
        Task<List<RecruitmentResponsibleViewModel>?> DeleteRecruitmentResponsible(int Id);
    }
}
