using AutoMapper;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

public class RecruitmentResponsibleRepository : GenericRepository<RecruitmentResponsibleViewModel, RecruitmentResponsible, int>, IRecruitmentResponsibleRepository
{
    public RecruitmentResponsibleRepository(DataContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
