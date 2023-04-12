using AutoMapper;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

public class ApproverRepository : GenericRepository<ApproverViewModel, Approver, int>, IApproverRepository
{
    public ApproverRepository(DataContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
