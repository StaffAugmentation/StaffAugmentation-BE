using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;
using System.Data.Common;
using Profile = Core.Model.Profile;

namespace Core.Repositories;

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
        ProfileViewModel profileVM = await _db.Profile
            .Where(profile => profile.Id == Id)
            .Select(profile => _mapper.Map<ProfileViewModel>(profile))
            .FirstOrDefaultAsync() ?? throw new Exception("Profile not found!");
        return profileVM; 
    }

    public async Task<ProfileViewModel?> CreateProfile(ProfileViewModel profileVM) 
    {
        Profile profile = _mapper.Map<Profile>(profileVM);

        await _db.Profile.AddAsync(profile);
        await _db.SaveChangesAsync();

        return _mapper.Map<ProfileViewModel>(profile);
    }

    public async Task<ProfileViewModel?> UpdateProfile(ProfileViewModel profileVM)
    {
        Profile profile = await _db.Profile.FindAsync(profileVM.Id) ?? throw new Exception("Profile not found!");

        profile.ValueId = profileVM.ValueId;
        profile.IsActive = profileVM.IsActive;

        await _db.SaveChangesAsync();

        return _mapper.Map<ProfileViewModel>(profile);
    }

    public async Task<List<ProfileViewModel>?> DeleteProfile(int Id)
    {
        Profile profile = await _db.Profile.FindAsync(Id) ?? throw new Exception("Profile not found!");

        _db.Profile.Remove(profile);
        await _db.SaveChangesAsync();

        return await GetProfile();
    }

}
