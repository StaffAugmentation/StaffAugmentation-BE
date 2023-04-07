namespace Core.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        IApproverRepository Approver {  get; }
        IBrSourceRepository BrSource {  get; }
        IBrTypeRepository BrType {  get; }
        ICategoryRepository Category {  get; }
        ICompanyRepository Company {  get; }
        IDepartmentRepository Department {  get; }
        IHighestDegreeRepository HighestDegree {  get; }
        ILevelRepository Level {  get; }
        IPaymentTermRepository PaymentTerm {  get; }
        IPlaceOfDeliveryRepository PlaceOfDelivery {  get; }
        IProfileRepository Profile {  get; }
        IPTMOwnerRepository PTMOwner {  get; }
        IRecruitmentResponsibleRepository RecruitmentResponsible { get; }
        IRequestFormStatusRepository RequestFormStatus { get; }
        ISubContractorRepository SubContractor { get; }
        ITypeOfCostRepository TypeOfCost { get; }
        ITypeRepository Type { get; }
        IOERPCodeRepository OERPCode { get; }
        IForecastRepository Forecast { get; }


        Task<int> CompleteAsync();
    }
}
