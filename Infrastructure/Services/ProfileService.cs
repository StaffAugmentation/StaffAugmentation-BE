using Business.IServices;
using Core.IRepositories;
using Core.Model;
using Core.ViewModel;

namespace Business.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IProfileRepository repo;
        public ProfileService(IProfileRepository ProfileRepository)
        {
            repo = ProfileRepository;
        }

        public async Task<List<ProfileViewModel>?> GetProfile()
        {
            return await repo.GetProfile();
        }

        public async Task<ProfileViewModel?> GetProfile(int Id)
        {
            return await repo.GetProfile(Id);
        }

        public async Task<ProfileViewModel?> CreateProfile(ProfileViewModel profile)
        {
            return await repo.CreateProfile(profile);
        }

        public async Task<ProfileViewModel?> UpdateProfile(ProfileViewModel profile)
        {
            return await repo.UpdateProfile(profile);
        }

        public async Task<List<ProfileViewModel>?> DeleteProfile(int Id)
        {
            return await repo.DeleteProfile(Id);
        }

    }
}
