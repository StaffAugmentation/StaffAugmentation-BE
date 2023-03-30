using AutoMapper;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;

namespace Core.Repositories;

public class ProfileRepository : GenericRepository<ProfileViewModel, Core.Model.Profile, int>, IProfileRepository
{
    public ProfileRepository(DataContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
