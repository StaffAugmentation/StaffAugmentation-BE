using AutoMapper;
using Core.Data;
using Core.Model;
using Core.ViewModel;
using Core.IRepositories;

namespace Core.Repositories;

public class BusinessRequestRepository : GenericRepository<BusinessRequestViewModel, BusinessRequest, int>, IBusinessRequestRepository
{
    public BusinessRequestRepository(DataContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
