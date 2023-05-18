using Microsoft.EntityFrameworkCore;
using Core.Model;

namespace Core.Data
{
    public class DataContext : DbContext
    {
        public DataContext() { }
        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public DbSet<Company> Company => Set<Company>();
        public DbSet<Level> Department => Set<Level>();
        public DbSet<Approver> Approver => Set<Approver>();
        public DbSet<Profile> Profile => Set<Profile>();
        public DbSet<BrSource> BrSource => Set<BrSource>();
        public DbSet<BrType> BrType => Set<BrType>();
        public DbSet<SubContractor> SubContractor => Set<SubContractor>();
        public DbSet<TypeOfCost> TypeOfCost => Set<TypeOfCost>();
        public DbSet<PaymentTerm> PaymentTerm => Set<PaymentTerm>();
        public DbSet<Level> Level => Set<Level>();
        public DbSet<PTMOwner> PTMOwner => Set<PTMOwner>();
        public DbSet<Core.Model.Type> Type => Set<Core.Model.Type>();
        public DbSet<Category> Category => Set<Category>();
        public DbSet<PlaceOfDelivery> PlaceOfDelivery => Set<PlaceOfDelivery>();
        public DbSet<RecruitmentResponsible> RecruitmentResponsible => Set<RecruitmentResponsible>();
        public DbSet<HighestDegree> HighestDegree => Set<HighestDegree>();
        public DbSet<RequestFormStatus> RequestFormStatus => Set<RequestFormStatus>();
        public DbSet<OERPCode> OERPCode => Set<OERPCode>();
        public DbSet<AppParameter> AppParameter => Set<AppParameter>();
        public DbSet<BusinessRequest> BusinessRequest => Set<BusinessRequest>();
        public DbSet<SprintContract> SprintContract => Set<SprintContract>();
        public DbSet<BRConsultant> BRConsultant => Set<BRConsultant>();
        public DbSet<Consultant> Consultant => Set<Consultant>();
        public DbSet<BRProfile> BRProfile => Set<BRProfile>();
        public DbSet<CurrencyRateParam> CurrencyRateParam => Set<CurrencyRateParam>();
        public DbSet<ServiceLevelCategory> ServiceLevelCategory => Set<ServiceLevelCategory>();
        public DbSet<UsersTypeOfContract> UsersTypeOfContract => Set<UsersTypeOfContract>();
        public DbSet<TypeOfContract> TypeOfContract => Set<TypeOfContract>();
        public DbSet<TypeOfContractSC> TypeOfContractSC => Set<TypeOfContractSC>();
        public DbSet<SprintContractOERPCode> SprintContractOERPCode => Set<SprintContractOERPCode>();
        public DbSet<BRProfileConsultant> BRProfileConsultant => Set<BRProfileConsultant>();
        public DbSet<ConsultantContractStatus> ConsultantContractStatus => Set<ConsultantContractStatus>();
    }
}
