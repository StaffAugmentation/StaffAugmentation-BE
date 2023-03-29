using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services;

public class RecruitmentResponsibleService : IRecruitmentResponsibleService
{
    private readonly IRecruitmentResponsibleRepository repo;
    public RecruitmentResponsibleService(IRecruitmentResponsibleRepository RecruitmentResponsibleRepository)
    {
        repo = RecruitmentResponsibleRepository;
    }

    public async Task<List<RecruitmentResponsibleViewModel>?> GetRecruitmentResponsible()
    {
        return await repo.GetRecruitmentResponsible();
    }

    public async Task<RecruitmentResponsibleViewModel?> GetRecruitmentResponsible(int Id)
    {
        return await repo.GetRecruitmentResponsible(Id);
    }

    public async Task<RecruitmentResponsibleViewModel?> CreateRecruitmentResponsible(RecruitmentResponsibleViewModel recruitmentResponsible)
    {
        return await repo.CreateRecruitmentResponsible(recruitmentResponsible);
    }

    public async Task<RecruitmentResponsibleViewModel?> UpdateRecruitmentResponsible(RecruitmentResponsibleViewModel recruitmentResponsible)
    {
        return await repo.UpdateRecruitmentResponsible(recruitmentResponsible);
    }

    public async Task<List<RecruitmentResponsibleViewModel>?> DeleteRecruitmentResponsible(int Id)
    {
        return await repo.DeleteRecruitmentResponsible(Id);
    }

}
