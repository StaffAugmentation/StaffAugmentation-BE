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
        public DbSet<Forecast> Forecast => Set<Forecast>();


    }
}
