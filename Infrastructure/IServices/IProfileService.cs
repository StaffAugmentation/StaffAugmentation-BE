using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;
using Core.ViewModel;

namespace Business.IServices
{
    public interface IProfileService
    {
        Task<List<ProfileViewModel>?> GetProfile();
        Task<ProfileViewModel?> GetProfile(int Id);
        Task<ProfileViewModel?> CreateProfile(ProfileViewModel profile);
        Task<ProfileViewModel?> UpdateProfile(ProfileViewModel profile);
        Task<List<ProfileViewModel>?> DeleteProfile(int Id);
    }
}