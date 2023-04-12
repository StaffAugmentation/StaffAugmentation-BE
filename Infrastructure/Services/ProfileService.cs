using Business.IServices;
using Core.IRepositories;
using Core.Model;
using Core.ViewModel;

namespace Business.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProfileService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<ProfileViewModel>?> GetProfile()
        {
            return await _unitOfWork.Profile.GetAll();
        }

        public async Task<ProfileViewModel?> GetProfile(int Id)
        {
            return await _unitOfWork.Profile.Find(profile => profile.Id == Id);
        }

        public async Task<ProfileViewModel?> CreateProfile(ProfileViewModel profile)
        {
            return await _unitOfWork.Profile.Create(profile);
        }

        public async Task<ProfileViewModel?> UpdateProfile(ProfileViewModel profile)
        {
            return await _unitOfWork.Profile.Update(profile.Id, profile);
        }

        public async Task<IEnumerable<ProfileViewModel>?> DeleteProfile(int Id)
        {
            return await _unitOfWork.Profile.Delete(Id);
        }

    }
}
