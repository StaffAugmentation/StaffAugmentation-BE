using Core.ViewModel;

namespace Business.IServices;

public interface IProfileService
{
    Task<IEnumerable<ProfileViewModel>?> GetProfile();
    Task<ProfileViewModel?> GetProfile(int Id);
    Task<ProfileViewModel?> CreateProfile(ProfileViewModel profile);
    Task<ProfileViewModel?> UpdateProfile(ProfileViewModel profile);
    Task<IEnumerable<ProfileViewModel>?> DeleteProfile(int Id);
}