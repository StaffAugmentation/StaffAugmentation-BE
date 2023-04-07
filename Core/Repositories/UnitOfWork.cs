using AutoMapper;
using Core.IRepositories;
using Core.Data;

namespace Core.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public IApproverRepository Approver { get; private set; }
        public IBrSourceRepository BrSource { get; private set; }
        public IBrTypeRepository BrType { get; private set; }
        public ICategoryRepository Category { get; private set; }
        public ICompanyRepository Company { get; private set; }
        public IDepartmentRepository Department { get; private set; }
        public IHighestDegreeRepository HighestDegree { get; private set; }
        public ILevelRepository Level { get; private set; }
        public IPaymentTermRepository PaymentTerm { get; private set; }
        public IPlaceOfDeliveryRepository PlaceOfDelivery { get; private set; }
        public IProfileRepository Profile { get; private set; }
        public IPTMOwnerRepository PTMOwner { get; private set; }
        public IRecruitmentResponsibleRepository RecruitmentResponsible { get; private set; }
        public IRequestFormStatusRepository RequestFormStatus { get; private set; }
        public ISubContractorRepository SubContractor { get; private set; }
        public ITypeOfCostRepository TypeOfCost { get; private set; }
        public ITypeRepository Type { get; private set; }
        public IOERPCodeRepository OERPCode { get; private set; }
        public IForecastRepository Forecast { get; private set; }


        public UnitOfWork(DataContext context, IMapper mapper)
        {
            _context = context;

            Approver = new ApproverRepository(_context, mapper);
            BrSource = new BrSourceRepository(_context, mapper);
            BrType = new BrTypeRepository(_context, mapper);
            Category = new CategoryRepository(_context, mapper);
            Company = new CompanyRepository(_context, mapper);
            Department = new DepartmentRepository(_context, mapper);
            HighestDegree = new HighestDegreeRepository(_context, mapper);
            Level = new LevelRepository(_context, mapper);
            PaymentTerm = new PaymentTermRepository(_context, mapper);
            PlaceOfDelivery = new PlaceOfDeliveryRepository(_context, mapper);
            Profile = new ProfileRepository(_context, mapper);
            PTMOwner = new PTMOwnerRepository(_context, mapper);
            RecruitmentResponsible = new RecruitmentResponsibleRepository(_context, mapper);
            RequestFormStatus = new RequestFormStatusRepository(_context, mapper);
            SubContractor = new SubContractorRepository(_context, mapper);
            TypeOfCost = new TypeOfCostRepository(_context, mapper);
            Type = new TypeRepository(_context, mapper);
            OERPCode = new OERPCodeRepository(_context, mapper);
            Forecast = new ForecastRepository(_context, mapper);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
