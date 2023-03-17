using Core.ViewModel;

namespace Core.IRepositories
{
    public interface IProfileRepository
    {
        Task<List<ProfileViewModel>?> GetProfile();
        Task<ProfileViewModel?> GetProfile(int Id);
        Task<ProfileViewModel?> CreateProfile(ProfileViewModel profile);
        Task<ProfileViewModel?> UpdateProfile(ProfileViewModel profile);
        Task<List<ProfileViewModel>?> DeleteProfile(int Id);
    }
}
