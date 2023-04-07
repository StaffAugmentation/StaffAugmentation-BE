using Core.Model;
using Core.ViewModel;

namespace Business.Mappers;

public class AutoMapperProfile : AutoMapper.Profile
{

    public AutoMapperProfile()
    {
        CreateMap<Company, CompanyViewModel>();
        CreateMap<CompanyViewModel, Company>();
        CreateMap<Approver, ApproverViewModel>();
        CreateMap<ApproverViewModel, Approver>();
        CreateMap<Level, DepartmentViewModel>();
        CreateMap<DepartmentViewModel, Level>();
        CreateMap<Profile, ProfileViewModel>();
        CreateMap<ProfileViewModel, Profile>();
        CreateMap<BrSource, BrSourceViewModel>();
        CreateMap<BrSourceViewModel, BrSource>();
        CreateMap<BrType, BrTypeViewModel>();
        CreateMap<BrTypeViewModel, BrType>();
        CreateMap<Level, LevelViewModel>();
        CreateMap<LevelViewModel, Level>();
        CreateMap<PTMOwner, PTMOwnerViewModel>();
        CreateMap<PTMOwnerViewModel, PTMOwner>();
        CreateMap<Core.Model.Type, TypeViewModel>();
        CreateMap<TypeViewModel, Core.Model.Type>();
        CreateMap<SubContractor, SubContractorViewModel>();
        CreateMap<SubContractorViewModel, SubContractor>();
        CreateMap<TypeOfCost, TypeOfCostViewModel>();
        CreateMap<TypeOfCostViewModel, TypeOfCost>();
        CreateMap<PaymentTerm, PaymentTermViewModel>();
        CreateMap<PaymentTermViewModel, PaymentTerm>();
        CreateMap<Category, CategoryViewModel>();
        CreateMap<CategoryViewModel, Category>();
        CreateMap<PlaceOfDelivery, PlaceOfDeliveryViewModel>();
        CreateMap<PlaceOfDeliveryViewModel, PlaceOfDelivery>();
        CreateMap<RecruitmentResponsible, RecruitmentResponsibleViewModel>();
        CreateMap<RecruitmentResponsibleViewModel, RecruitmentResponsible>();
        CreateMap<RequestFormStatus, RequestFormStatusViewModel>();
        CreateMap<RequestFormStatusViewModel, RequestFormStatus>();
        CreateMap<HighestDegree, HighestDegreeViewModel>();
        CreateMap<HighestDegreeViewModel, HighestDegree>();
        CreateMap<OERPCode, OERPCodeViewModel>();
        CreateMap<OERPCodeViewModel, OERPCode>();
        CreateMap<Forecast, ForecastViewModel>();
        CreateMap<ForecastViewModel, Forecast>();
    }
}
