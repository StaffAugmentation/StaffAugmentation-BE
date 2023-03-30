using Core.Model;
using Core.ViewModel;

namespace Core.IRepositories;

public interface IRequestFormStatusRepository : IGenericRepository<RequestFormStatusViewModel, RequestFormStatus, string>
{
}
