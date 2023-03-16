using AutoMapper;
using Core.Model;
using Core.ViewModel;

namespace Business.Mappers;

public class AutoMapperProfile : Profile
{

    public AutoMapperProfile()
    {
        CreateMap<Company, CompanyViewModel>();
        CreateMap<CompanyViewModel, Company>();
        CreateMap<Approvers, ApproversViewModel>();
        CreateMap<ApproversViewModel, Approvers>();
        CreateMap<Department, DepartmentViewModel>();
        CreateMap<DepartmentViewModel, Department>();
        CreateMap<BrType, BrTypeViewModel>();
        CreateMap<BrTypeViewModel, BrType>();
    }
}
