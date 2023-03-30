using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services;

public class RecruitmentResponsibleService : IRecruitmentResponsibleService
{
    private readonly IUnitOfWork _unitOfWork;

    public RecruitmentResponsibleService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<RecruitmentResponsibleViewModel>?> GetRecruitmentResponsible()
    {
        return await _unitOfWork.RecruitmentResponsible.GetAll();
    }

    public async Task<RecruitmentResponsibleViewModel?> GetRecruitmentResponsible(int Id)
    {
        return await _unitOfWork.RecruitmentResponsible.Find(entity => entity.Id == Id);
    }

    public async Task<RecruitmentResponsibleViewModel?> CreateRecruitmentResponsible(RecruitmentResponsibleViewModel recruitmentResponsible)
    {
        return await _unitOfWork.RecruitmentResponsible.Create(recruitmentResponsible);
    }

    public async Task<RecruitmentResponsibleViewModel?> UpdateRecruitmentResponsible(RecruitmentResponsibleViewModel recruitmentResponsible)
    {
        return await _unitOfWork.RecruitmentResponsible.Update(recruitmentResponsible.Id, recruitmentResponsible);
    }

    public async Task<IEnumerable<RecruitmentResponsibleViewModel>?> DeleteRecruitmentResponsible(int Id)
    {
        return await _unitOfWork.RecruitmentResponsible.Delete(Id);
    }

}
