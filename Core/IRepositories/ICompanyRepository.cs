using Core.Model;
using Core.ViewModel;

namespace Core.IRepositories;

public interface ICompanyRepository : IGenericRepository<CompanyViewModel, Company, int>
{
}
