using Core.Model;
using Core.ViewModel;

namespace Core.IRepositories;

public interface IProfileRepository : IGenericRepository<ProfileViewModel, Profile, int>
{
}
