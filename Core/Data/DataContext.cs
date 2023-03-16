using Microsoft.EntityFrameworkCore;
using Core.Model;
using Core.Model.Profile;

namespace Core.Data
{
    public class DataContext : DbContext
    {
        public DataContext() { }
        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public DbSet<Company> Company => Set<Company>();
        public DbSet<Department> Department => Set<Department>();
        public DbSet<Approvers> Approvers => Set<Approvers>();
        public DbSet<BrSource> BrSource => Set<BrSource>();
        public DbSet<Profile> Profile => Set<Profile>();
    }
}
