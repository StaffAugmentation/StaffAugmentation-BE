using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;
using System.Data.Common;
using Profile = Core.Model.Profile;

namespace Core.Repositories
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly DataContext _db;
        private readonly IMapper _mapper;

        public ProfileRepository(DataContext context, IMapper mapper)
        {
            _db = context;
            _mapper = mapper;
        }

        public async Task<List<ProfileViewModel>?> GetProfile()
        {
            return await _db.Profile.Select(profile => _mapper.Map<ProfileViewModel>(profile)).ToListAsync();
        }
        
        public async Task<ProfileViewModel?> GetProfile(int Id)
        {
            var dbProfile = await _db.Profile.Where(profile => profile.Id == Id).Select(profile => _mapper.Map<ProfileViewModel>(profile)).FirstOrDefaultAsync();
            if (dbProfile == null)
                throw new Exception("Profile not found!");
            return dbProfile; 
        }

        public async Task<ProfileViewModel?> CreateProfile(ProfileViewModel profile) 
        {
            var dbProfile = await _db.Profile.AddAsync(_mapper.Map<Profile>(profile));
            await _db.SaveChangesAsync();

            return _mapper.Map<ProfileViewModel>(dbProfile.Entity);
        }

        public async Task<ProfileViewModel?> UpdateProfile(ProfileViewModel profile)
        {
            var dbProfile = await _db.Profile.FindAsync(profile.Id);
            if (dbProfile == null)
                throw new Exception("Profile not found!");

            dbProfile.ValueId = profile.ValueId;
            dbProfile.IsActive = profile.IsActive;
            
            await _db.SaveChangesAsync();
            return _mapper.Map<ProfileViewModel>(dbProfile);
        }

        public async Task<List<ProfileViewModel>?> DeleteProfile(int Id)
        {
            var dbProfile = await _db.Profile.FindAsync(Id);
            if (dbProfile == null)
                throw new Exception("Profile not found!");

            _db.Profile.Remove(dbProfile);
            await _db.SaveChangesAsync();

            return await GetProfile();
        }

    }
}
