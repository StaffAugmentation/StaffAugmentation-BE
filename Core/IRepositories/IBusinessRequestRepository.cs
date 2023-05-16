using Core.Model;
using Core.ViewModel;

namespace Core.IRepositories;

public interface IBusinessRequestRepository : IGenericRepository<BusinessRequestViewModel, BusinessRequest, int>
{
}
