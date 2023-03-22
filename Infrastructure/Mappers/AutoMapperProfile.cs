using Core.Model;
using Core.ViewModel;

namespace Business.Mappers;

public class AutoMapperProfile : AutoMapper.Profile
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
        CreateMap<Core.Model.Type, TypeViewModel>();
        CreateMap<TypeViewModel, Core.Model.Type>();
        CreateMap<PlaceOfDelivery, PlaceOfDeliveryViewModel>();
        CreateMap<PlaceOfDeliveryViewModel, PlaceOfDelivery>();
    }
}
