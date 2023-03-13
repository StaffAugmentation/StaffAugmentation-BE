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

        CreateMap<Approver, ApproverViewModel>();
        CreateMap<ApproverViewModel, Approver>();
    }
}
