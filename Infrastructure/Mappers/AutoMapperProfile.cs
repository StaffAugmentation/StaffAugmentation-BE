using AutoMapper;
using Core.Model;
using Core.ViewModel;
using Profile = Core.Model.Profile;
using Profiles = AutoMapper.Profile;

namespace Business.Mappers;

public class AutoMapperProfile : Profiles
{

    public AutoMapperProfile()
    {
        CreateMap<Company, CompanyViewModel>();
        CreateMap<CompanyViewModel, Company>();
        CreateMap<Approvers, ApproversViewModel>();
        CreateMap<ApproversViewModel, Approvers>();
        CreateMap<Department, DepartmentViewModel>();
        CreateMap<DepartmentViewModel, Department>();
        CreateMap<Profile, ProfileViewModel>();
        CreateMap<ProfileViewModel, Profile>();
        CreateMap<BrSource, BrSourceViewModel>();
        CreateMap<BrSourceViewModel, BrSource>();
        CreateMap<BrType, BrTypeViewModel>();
        CreateMap<BrTypeViewModel, BrType>();
        CreateMap<Level, LevelViewModel>();
        CreateMap<LevelViewModel, Level>();
    }
}
