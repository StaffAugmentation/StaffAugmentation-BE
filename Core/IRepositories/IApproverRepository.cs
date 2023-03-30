using Core.Model;
using Core.ViewModel;

namespace Core.IRepositories;

public interface IApproverRepository : IGenericRepository<ApproverViewModel, Approver, int>
{
}
