using AutoMapper;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

public class RequestFormStatusRepository : GenericRepository<RequestFormStatusViewModel, RequestFormStatus, string>, IRequestFormStatusRepository
{
    public RequestFormStatusRepository(DataContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
