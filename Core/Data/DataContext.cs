using Microsoft.EntityFrameworkCore;
using Core.Model;

namespace Core.Data
{
    public class DataContext : DbContext
    {
        public DataContext() { }
        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public DbSet<Company> Company => Set<Company>();
        public DbSet<Department> Department => Set<Department>();
        public DbSet<Approvers> Approvers => Set<Approvers>();
    }
}
